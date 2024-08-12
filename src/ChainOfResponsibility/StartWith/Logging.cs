using Common;

namespace DemoOne
{
    internal class Logging
    {
        private readonly bool _enableConsole;

        public Logging(bool enableConsole)
        {
            _enableConsole = enableConsole;
        }

        public bool HandleRequest(Request request)
        {
            if (_enableConsole)
                Console.WriteLine($"{DateTime.UtcNow} - Request received from user {request.UserName} for resource {request.Endpoint}.");

            // Add enterprise logging
            
            return true;
        }
    }
}
