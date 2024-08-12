namespace DemoThree
{
    public class ApplicationBuilder
    {
        private ApplicationBuilder() { }

        public static ApplicationBuilder Instance => new ApplicationBuilder();

        private RequestHandler _firstHandler;
        private RequestHandler _lastHandler;

        private void AddHandler(RequestHandler handler)
        {
            _firstHandler ??= handler;

            if (_lastHandler != null) _lastHandler.SetNext(handler);

            _lastHandler = handler;
        }

        public ApplicationBuilder UseRouting()
        {
            AddHandler(new Routing());

            return this;
        }

        public ApplicationBuilder UseAuthentication()
        {
            AddHandler(new Authentication());

            return this;
        }

        public ApplicationBuilder UseLogging(bool enableConsoleLogging)
        {
            AddHandler(new Logging(enableConsoleLogging));

            return this;
        }

        public ApplicationBuilder UseCustom(RequestHandler handler)
        {
            AddHandler(handler);

            return this;
        }

        public RequestHandler Build()
        {
            AddHandler(new Execution());

            return _firstHandler;
        }
    }
}
