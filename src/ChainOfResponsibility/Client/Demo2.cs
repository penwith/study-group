using Common;
using DemoTwo;

namespace Client
{
    internal static class Demo2
    {
        public static void Run(Request request)
        {
            new RequestPipeline().Process(request, true);
        }
    }
}
