using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    // The Observer interface
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
