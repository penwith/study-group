using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Observe
{
    public interface IObserver
    {
        void Update(string symbol, double price);
    }

    public class Investor : IObserver
    {
        private readonly ISubject _stock;

        public Investor(ISubject stock)
        {
            _stock = stock;
            _stock.AddInvestor(this);
        }

        public string Name { get; set; } = null!;
        public void Update(string symbol, double price)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:C}", Name, symbol, price);
        }
    }
}
