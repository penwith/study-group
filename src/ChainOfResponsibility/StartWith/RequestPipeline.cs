using Common;

namespace DemoOne
{
    public class RequestPipeline
    {
        public void Process(Request request, bool withLogging)
        {
            var routing = new Routing();
            var authentication = new Authentication();
            var logging = new Logging(withLogging);
            var execution = new Execution();

            var isValid = routing.HandleRequest(request);

            isValid = isValid && authentication.HandleRequest(request);

            isValid = isValid && logging.HandleRequest(request);

            isValid = isValid && execution.HandleRequest(request);
        }
    }
}
