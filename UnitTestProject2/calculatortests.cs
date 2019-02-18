using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator
{

    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void DivisionTest()
        {
            var calc = new Calculator();
            int a = 4;
            int b = 2;
            int expected = 2;
            int result = calc.Div(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddingTest()
        {
            var calc = new Calculator();
            int a = 5;
            int b = 4;
            int result = calc.Add(a, b);
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "error")]
        public void DivisionExceptionTest()
        {
            var calc = new Calculator();
            int a = 4;
            int b = 0;
            int result = calc.Div(a, b);

        }

    }
}
