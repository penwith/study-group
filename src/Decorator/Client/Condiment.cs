using Condiments.Drinks;

namespace Client
{
    internal static class Condiment
    {
        public static void Run()
        {
            var beverage = new HouseBlend();
            
            Console.Write("Do you want milk? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y) beverage.HasMilk = true;
            Console.WriteLine();

            Console.Write("Do you want soya? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y) beverage.HasSoya = true;
            Console.WriteLine();

            Console.Write("Do you want mocha? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y) beverage.HasMocha = true;
            Console.WriteLine();

            Console.Write("Do you want cream? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y) beverage.HasCream = true;
            Console.WriteLine();

            Console.WriteLine($"That will be £{beverage.Cost()}");
            Console.WriteLine($"Here's your {beverage.Description}...");
            Console.ReadKey();
        }
    }
}
