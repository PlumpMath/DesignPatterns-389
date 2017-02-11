using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CommandPattern
{
    // In the Command Pattern, this Interface defines what must exist in all the Command objects
    public interface ITransaction
    {
        bool IsCompleted { get; set; }
        void Execute();
    }
}
