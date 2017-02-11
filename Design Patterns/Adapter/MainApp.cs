using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter
{
    class MainApp
    {
        // The Adapter design pattern is part falls under the the Structural Pattern category
        // Adapter design pattern is intended to convert the interface of a class into another interface clients expect.
        // Adapters let classes work together that have incompatible interfaces
        // Main classes and object in this design pattern are the TARGET (Chemical_, ADAPTER(Compound), ADAPTE(ChemicalDatabank), and CLIENT(AdapterApp)

        // Adapter design pattern reference from: http://www.dofactory.com/net/adapter-design-pattern


        // Entry point into console application
        static void Main()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
