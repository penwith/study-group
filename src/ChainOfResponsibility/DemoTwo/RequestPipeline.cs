using Common;

namespace DemoTwo
{
    public class RequestPipeline
    {
        public void Process(Request request, bool withLogging)
        {
            var routing = new Routing();
            var authentication = new Authentication();
            var logging = new Logging(withLogging);
            var execution = new Execution();

            routing.SetNext(authentication);
            authentication.SetNext(logging);
            logging.SetNext(execution);

            routing.HandleRequest(request);
        }
    }
}
