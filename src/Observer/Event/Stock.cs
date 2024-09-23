namespace Event
{
    public interface ISubject
    {
        void AddInvestor(IObserver observer);
        void RemoveInvestor(IObserver investor);
    }

    public abstract class Stock : ISubject
    {
        private readonly string _symbol;
        private double _price;

        protected Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public event EventHandler<ChangeEventArgs> Change = null!;

        private void OnChange(ChangeEventArgs e)
        {
            Change?.Invoke(this, e);
        }

        public void AddInvestor(IObserver investor)
        {
            Change += investor.Update!;
        }

        public void RemoveInvestor(IObserver investor)
        {
            Change -= investor.Update!;
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
                    OnChange(new ChangeEventArgs { Symbol = _symbol, Price = _price });
                }
            }
        }
    }

    public class Msft(double price) : Stock("MSFT", price) { }
}
