using Common;

namespace DemoTwo
{
    internal class Routing : RequestHandler
    {
        private readonly List<string> _endpoints = new List<string>
        {
            "Get",
            "Update"
        };

        public override void HandleRequest(Request request)
        {
            if (_endpoints.Any(e => e == request.Endpoint))
            {
                Console.WriteLine($"Routing request to {request.Endpoint} endpoint...");

                if (NextHandler != null) NextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine($"Invalid request for unknown endpoint {request.Endpoint}");
            }
        }
    }
}
