namespace Initial
{
    public abstract class Stock
    {
        private readonly string _symbol;
        private double _price;

        protected Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public string Symbol => _symbol;

        public double Price
        {
            get => _price;
            set
            {
                if (_price.CompareTo(value) != 0)
                {
                    _price = value;
                    Console.WriteLine("");
                }
            }
        }
    }

    public class Microsoft(double price) : Stock("MSFT", price) { }
}
