using Common;

namespace DemoOne
{
    internal class Execution
    {
        public bool HandleRequest(Request request)
        {
            Console.WriteLine("Request handled");

            return true;
        }
    }
}
