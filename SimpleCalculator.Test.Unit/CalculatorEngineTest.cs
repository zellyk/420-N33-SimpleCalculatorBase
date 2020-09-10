using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorEngine;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly Engine _calculatorEngine = new Engine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }
    }
}
