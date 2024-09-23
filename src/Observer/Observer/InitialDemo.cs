using Initial;

namespace Client
{
    public static class InitialDemo
    {
        public static void Run()
        {
            var stock = new Msft(435.27);

            var kevin = new Investor { Name = "Kevin" };
            var sheila = new Investor { Name = "Sheila" };

            while (true)
            {
                Console.Write("Last {0} price was {1:C} - enter new price: ", stock.Symbol, stock.Price);

                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) break;

                stock.Price = double.Parse(input);

                kevin.Update(stock.Symbol, stock.Price);
                sheila.Update(stock.Symbol, stock.Price);

                Console.WriteLine();
            }
        }
    }
}
