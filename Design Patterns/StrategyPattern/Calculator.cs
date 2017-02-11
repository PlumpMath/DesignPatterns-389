using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern
{
    // Calculator main class
    public class Calculator
    {
        public double CalculateAverageFor(List<double> values, IAverage average)
        {
            return average.AverageFor(values);
        }
    }
}
