using Common;
using DemoThree;

namespace Client
{
    internal static class Demo3
    {
        public static void Run(Request request)
        {
            var app = ApplicationBuilder.Instance
                .UseRouting()
                .UseAuthentication()
                .UseCustom(new Greetings("Hello World"))
                .UseLogging(true)
                .Build();

            app.HandleRequest(request);
        }
    }

    public class Greetings : RequestHandler
    {
        private readonly string _greeting;

        public Greetings(string greeting)
        {
            _greeting = greeting;
        }

        public override void HandleRequest(Request request)
        {
            Console.WriteLine(_greeting);

            if (NextHandler != null) NextHandler.HandleRequest(request);
        }
    }
}
