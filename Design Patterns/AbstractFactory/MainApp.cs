using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory
{
    public class MainApp
    {
        // The Abstract Factory Design Pattern falls under the Creational Pattern category
        // Abstract Factory design pattern provides an interface for creating families of related dependent objects without specifying their concrete classes
        // Classes and objects in Abstract Factory design pattern are ABSTRACTFACTORY (ContinentFactory), CONCRETEFACTORY(AfricaFactory & AmericaFactory), ABSTRACTPRODUCT(Herbivore & Carnivore), PRODUCT (Wildebeast, Lion, Bison, & Wolf), and CLIENT (AnimalWorld)
        // reference from: http://www.dofactory.com/net/abstract-factory-design-pattern

        public static void Main()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadKey();
        }
    }


}
