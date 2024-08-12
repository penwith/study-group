using Common;

namespace DemoTwo
{
    internal class Execution : RequestHandler
    {
        public override void HandleRequest(Request request)
        {
            Console.WriteLine("Request handled");

            if (NextHandler != null) NextHandler.HandleRequest(request);
        }
    }
}
