using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // In this case, wolf eats bison
            Console.WriteLine(GetType().Name + " eats " + h.GetType().Name);            
        }
    }
}
