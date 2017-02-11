using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // In this case, lion eats wildebeast
            Console.WriteLine(GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
