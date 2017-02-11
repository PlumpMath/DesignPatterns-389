using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    // The ConcreteObserver class
    class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {_name} of {stock.Symbol}'s change to {stock.Price}"); // C# 6.0 string interlopation
        }

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
