using TemplateMethod;

namespace Client
{
    public static class Demo
    {
        public static void Run()
        {
            var coffee = new Coffee();
            var tea = new Tea();

            Console.WriteLine("Preparing coffee...");
            coffee.Prepare();

            Console.WriteLine();
            Console.WriteLine("Preparing tea...");
            tea.Prepare();

            Console.ReadKey();
        }
    }
}
