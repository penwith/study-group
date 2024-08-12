using Common;

namespace DemoThree
{
    internal class Logging : RequestHandler
    {
        private readonly bool _enableConsole;

        public Logging(bool enableConsole)
        {
            _enableConsole = enableConsole;
        }

        public override void HandleRequest(Request request)
        {
            if (_enableConsole)
                Console.WriteLine($"{DateTime.UtcNow} - Request received from user {request.UserName} for resource {request.Endpoint}.");

            // Add enterprise logging

            if (NextHandler != null) NextHandler.HandleRequest(request);
        }
    }
}
