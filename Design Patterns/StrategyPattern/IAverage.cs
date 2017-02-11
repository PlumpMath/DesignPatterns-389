using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern
{
    // Interface for the Strategy classes
    public interface IAverage
    {
        double AverageFor(List<double> values);
    }
}
