namespace Initial
{
    public class Investor
    {
        public string Name { get; set; } = null!;
        public void Update(string symbol, double price)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:C}", Name, symbol, price);
        }
    }
}
