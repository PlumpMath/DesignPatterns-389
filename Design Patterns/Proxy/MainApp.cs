using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    // The Proxy Design Pattern falls under the Structural Pattern category
    // The Proxy Design Pattern provides a placeholder for another object to control access to it
    // The classes and objects in the pattern include the Proxy(MathProxy), Subject(IMath), and RealSubject(Math)
    // Referenced from: http://www.dofactory.com/net/proxy-design-pattern
    class MainApp
    {
        static void Main()
        {
            //Create math proxy
            MathProxy proxy = new MathProxy();

            // Math equations
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Subtract(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Multiply(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Divide(4, 2));

            Console.ReadKey();
        }
    }
}
