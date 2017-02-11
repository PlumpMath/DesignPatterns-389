using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    // Concrete Iterator class
    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Item;
            else
                return null;
        }

        // Gets or sets stepsize
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public Item CurrentItem => _collection[_current] as Item;

        public bool IsDone => _current >= _collection.Count;

    }
}
