using Common;

namespace DemoOne
{
    internal class Authentication
    {
        private readonly List<string> _users = new List<string>
        {
            "User1",
            "User2"
        };

        public bool HandleRequest(Request request)
        {
            if (_users.Any(e => e == request.UserName))
            {
                Console.WriteLine($"Authenticated user {request.UserName}...");
                return true;
            }

            Console.WriteLine($"Unauthenticated user {request.UserName}. Terminating request.");
            return false;
        }
    }
}
