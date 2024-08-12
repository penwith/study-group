using Common;

namespace DemoOne
{
    internal class Routing
    {
        private readonly List<string> _endpoints = new List<string>
        {
            "Get",
            "Update"
        };

        public bool HandleRequest(Request request)
        {
            if (_endpoints.Any(e => e == request.Endpoint))
            {
                Console.WriteLine($"Routing request to {request.Endpoint} endpoint...");
                return true;
            }

            Console.WriteLine($"Invalid request for unknown endpoint {request.Endpoint}");
            return false;
        }
    }
}
