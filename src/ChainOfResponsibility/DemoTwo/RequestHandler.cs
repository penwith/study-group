using Common;

namespace DemoTwo
{
    internal abstract class RequestHandler
    {
        protected RequestHandler NextHandler = default!;

        public abstract void HandleRequest(Request request);

        public void SetNext(RequestHandler handler) => NextHandler = handler;
    }
}
