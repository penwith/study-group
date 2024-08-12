using Common;

namespace DemoTwo
{
    internal class Authentication : RequestHandler
    {
        private readonly List<string> _users = new List<string>
        {
            "User1",
            "User2"
        };

        public override void HandleRequest(Request request)
        {
            if (_users.Any(e => e == request.UserName))
            {
                Console.WriteLine($"Authenticated user {request.UserName}...");

                if (NextHandler != null) NextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine($"Unauthenticated user {request.UserName}. Terminating request.");
            }
        }
    }
}
