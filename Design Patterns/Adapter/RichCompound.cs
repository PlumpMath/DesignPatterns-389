using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter
{
    // The "Adapter" class
    class RichCompound : Compound
    {
        private ChemicalDatabank _bank;

        // Constructor
        public RichCompound(string name) : base(name)
        {

        }

        public override void Display()
        {
            //The adaptee
            _bank = new ChemicalDatabank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);

            base.Display();

            Console.WriteLine($" Formula: {_molecularFormula}");
            Console.WriteLine($" Weight: { _molecularWeight}");
            Console.WriteLine($" MeltingPoint: {_meltingPoint}");
            Console.WriteLine($" BoilingPoint: {_boilingPoint}");
        }
    }
}
