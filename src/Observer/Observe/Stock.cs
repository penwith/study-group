using System.Collections;

namespace Observe
{
    public interface ISubject
    {
        void AddInvestor(IObserver observer);
    }

    public abstract class Stock : ISubject
    {
        private readonly string _symbol;
        private double _price;

        private readonly ArrayList _investors;

        protected Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;

            _investors = [];
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
                    UpdateInvestors();
                }
            }
        }

        private void UpdateInvestors()
        {
            foreach (var i in _investors)
            {
                var investor = i as Investor;

                investor?.Update(_symbol, _price);
            }
        }

        public void AddInvestor(IObserver observer)
        {
            _investors.Add(observer);
        }
    }

    public class Msft(double price) : Stock("MSFT", price) { }
}
