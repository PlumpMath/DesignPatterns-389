using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter
{
    // Target class
    class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        public Compound(string chemical)
        {
            _chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\n Compound: {_chemical} ---------------");
        }
    }
}
