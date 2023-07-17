using ManyBeverages;
using ManyBeverages.Drinks;

namespace Client
{
    internal static class Bevvy
    {
        public static void Run()
        {
            Beverage beverage = new HouseBlend();

            Console.WriteLine($"That will be £{beverage.Cost()}");
            Console.WriteLine($"Here's your {beverage.Description}...");
            Console.ReadKey();

            beverage = new DarkRoastWithMilk();

            Console.WriteLine($"That will be £{beverage.Cost()}");
            Console.WriteLine($"Here's your {beverage.Description}...");
            Console.ReadKey();

            beverage = new DarkRoastWithMilkAndMocha();

            Console.WriteLine($"That will be £{beverage.Cost()}");
            Console.WriteLine($"Here's your {beverage.Description}...");
            Console.ReadKey();
        }
    }
}
