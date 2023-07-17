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

            beverage = new Mocha(beverage);
            beverage = new Milk(beverage);
            beverage = new Cream(beverage);

            Console.WriteLine($"That will be £{beverage.Cost()}");
            Console.WriteLine($"Here's your {beverage.Description}...");
            Console.ReadKey();
        }
    }
}
