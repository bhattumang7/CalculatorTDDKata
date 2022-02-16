using CalculatorTDDKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculatorKata
{
    [TestClass]
    public class TestNumberOperations
    {
        [TestMethod]
        public void TestSum_TestBlankInput()
        {
            NumberOperation numberOperation = new NumberOperation();
            int sum = numberOperation.Add("");
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        public void TestSum_TestSingleDigitInput()
        {
            NumberOperation numberOperation = new NumberOperation();
            int sum = numberOperation.Add("1");
            Assert.AreEqual(1, sum);
        }


    }
}
