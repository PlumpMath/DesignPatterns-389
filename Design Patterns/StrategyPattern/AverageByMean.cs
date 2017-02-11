using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern
{
    // The Strategy Design Pattern is part of the Behavioral Pattern category
    // Developers can use the strategy design pattern to perform a function with many techniques
    // Preferably used when there are at least five different ways to perform the startegy's function
    // Preferably used to reuse concrete strategy classes in several places
    // Strategy design pattern often used to validate a business object with several ways of validating
    // This design pattern and the Command Design Pattern are examples of dependency inversion
    // dependency inversion is a technique that makes code easier to modify and easier to test
    // This design pattern implements "composition over inheritance"

    // AverageByMean concrete strategy class
    public class AverageByMean : IAverage
    {
        public double AverageFor(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
