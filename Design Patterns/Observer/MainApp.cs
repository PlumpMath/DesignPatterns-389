using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    // The Observer Design Pattern falls under the Behavioral Pattern category
    // The Observer Design Pattern provides a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically
    // Classes and objects used in the Observer Design Pattern the Subject(Stock), ConcreteSubject(IBM), Observer(IInvestor), and ConcreteObserver(Investor)
    // Reference from: http://www.dofactory.com/net/observer-design-pattern

    class MainApp
    {
        static void Main()
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Martinez"));
            ibm.Attach(new Investor("Silva"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            Console.ReadKey();


        }
    }
}
