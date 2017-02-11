using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    class Item
    {
        private string _name;

        // Constructor
        public Item(string name)
        {
            _name = name;
        }

        // Gets name
        public string Name => _name; // C# 6.0 equal to public string Name { get { return _name } } Expression-Bodied Get-Only Properties
    }
}
