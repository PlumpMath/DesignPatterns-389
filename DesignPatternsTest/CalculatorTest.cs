using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Design_Patterns.StrategyPattern;

namespace DesignPatternsTest
{
    // Calculator test tests the calculator class in the strategy design pattern folder
    [TestClass]
    public class CalculatorTest
    {
        private readonly List<double> _values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };
        [TestMethod]
        public void Average_MeanofGivenValues_AverageMeanOfArrayOrCollection()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var averageByMean = calculator.CalculateAverageFor(_values, new AverageByMean());

            //Assert
            Assert.IsTrue(ResultsAreCloseEnough(8.3636363, averageByMean));
        }

        [TestMethod]
        public void Average_MedianOfGivenValues_AverageMedianOfArrayOrCollection()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var averageByMedian = calculator.CalculateAverageFor(_values, new AverageByMedian());

            //Assert
            Assert.IsTrue(ResultsAreCloseEnough(8, averageByMedian));
        }

        private bool ResultsAreCloseEnough(double expectedResult, double calculatedResult)
        {
            var difference = Math.Abs(expectedResult - calculatedResult);

            return difference < .000001;
        }
    }
}
