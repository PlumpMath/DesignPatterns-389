using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    // The Iterator Design Pattern falls under the Behavioral Pattern category
    // The Iterator Design Pattern allows access to the elements of an aggregate object sequentually wihtout exposing the underlying representation
    // Futhermore, the Iterator Design Pattern is used to iterate over a collection of items and skip a specific number of items each iteration
    // The classes and objects in the Iterator Design Pattern include the Iterator (AbstractIterator), ConcreteIterator (Iterator), Aggregate (AbstractCollection), and Concrete Aggregate (Collection)
    // Reference from: http://www.dofactory.com/net/iterator-design-pattern
    class MainApp
    {
        static void Main()
        {
            // The collection
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Instantiate the iterator
            Iterator iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over collection");

            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
