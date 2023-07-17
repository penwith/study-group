using Decorators;
using Decorators.Condiments;
using Decorators.Drinks;

namespace Client
{
    internal static class Decorator
    {
        public static void Run()
        {
            Beverage beverage = new DarkRoast();
            
            Console.WriteLine($"That will be £{beverage.Cost()}");
            Console.WriteLine($"Here's your {beverage.Description}...");
            Console.ReadKey();
        }
    }
}
