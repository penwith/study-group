using Event;

namespace Client
{
    public static class EventDemo
    {
        public static void Run()
        {
            Stock stock = new Msft(435.27);

            _ = new Investor(stock) { Name = "Kevin" };
            _ = new Investor(stock) { Name = "Sheila" };

            while (true)
            {
                Console.Write("Last {0} price was {1:C} - enter new price: ", stock.Symbol, stock.Price);

                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) break;

                stock.Price = double.Parse(input);

                Console.WriteLine();
                Console.Write("Add investor? ");

                var name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                    _ = new Investor(stock) { Name = name };

                Console.WriteLine();
            }
        }
    }
}
