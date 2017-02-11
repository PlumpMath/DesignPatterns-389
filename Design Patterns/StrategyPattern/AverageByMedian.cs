using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern
{
    // AverageByMedian concrete Stragegy class
    public class AverageByMedian : IAverage
    {
        public double AverageFor(List<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            if (sortedValues.Count % 2 == 1)
            {
                return sortedValues[(sortedValues.Count - 1) / 2];
            }

            return (sortedValues[(sortedValues.Count / 2) - 1] + sortedValues[sortedValues.Count / 2]) / 2;
        }
    }
}
