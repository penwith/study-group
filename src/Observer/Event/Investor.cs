using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public interface IObserver
    {
        void Update(object sender, ChangeEventArgs e);
    }

    public class Investor : IObserver, IDisposable
    {
        private readonly ISubject _stock;

        public Investor(ISubject stock)
        {
            _stock = stock;
            stock.AddInvestor(this);
        }

        public string Name { get; set; } = null!;
        public void Update(object? sender, ChangeEventArgs e)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:C}", Name, e.Symbol, e.Price);
        }

        public void Dispose()
        {
            _stock.RemoveInvestor(this);
        }
    }

    public class ChangeEventArgs : EventArgs
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
    }
}
