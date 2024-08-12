using Common;
using DemoOne;

namespace Client
{
    internal static class Demo1
    {
        public static void Run(Request request)
        {
            new RequestPipeline().Process(request, true);
        }
    }
}
