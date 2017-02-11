using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Composite
{
    // Composite Design pattern falls under the Structural Pattern category
    // Composite design pattern allows clients treat individual objects and compositions of objects uniformly
    // referenced from: http://www.dofactory.com/net/composite-design-pattern
    // Classes and objects in this pattern include the Component (Drawing Pattern), Leaf (Primitive Element), Composite (CompositeElement), and Client (Composite App)

    class MainApp
    {
        // Entry point in console application

        static void Main()
        {
            // creates a tree structure
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Picture"));
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // creates a branch on the tree structure
            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);

            // Wait for user
            Console.ReadKey();
        }
    }


}
