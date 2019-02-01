using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FancyCalc
{
    [TestFixture]
    public class CalculatorTests
    {

        [TestCase("3+3", ExpectedResult = 9)]
        [TestCase("1 *  0", ExpectedResult = 0)]
        [TestCase("10 -  9", ExpectedResult = 1)]
        [Property("Mark", 5)]
        public double CalculateTestHidden(string expression)
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            return calc.Culculate(expression);
        }

        [Test]
        [Property("Mark", 5)]
        public void CalculateTest_IfArgument_IsNull_Throws_ArgumentNullException()
             => Assert.Throws<ArgumentNullException>(() => new FancyCalcEnguine().Culculate(null)
            , "Expression for Calcilate method cannot be null");


        [Test]
        public void AddTestHidden()
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            double expected = 4;
            double actual = calc.Add(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractTestHidden()
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            double expected = 0;
            double actual = calc.Subtract(1, 1);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(3, 3, ExpectedResult = 9)]
        [TestCase(1, 0, ExpectedResult = 0)]
        public double MultiplyTestHidden(int a, int b)
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            return calc.Multiply(a, b);
        }


    }
}
