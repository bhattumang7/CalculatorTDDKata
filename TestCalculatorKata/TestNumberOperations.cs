using CalculatorTDDKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculatorKata
{
    [TestClass]
    public class TestNumberOperations
    {
        NumberOperation _numberOperation = null;

        [TestInitialize]
        public void InitializeTest()
        {
            _numberOperation = new NumberOperation();
        }
        [TestMethod]
        public void TestSum_TestBlankInput()
        {   
            int sum = _numberOperation.Add("");
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        public void TestSum_TestSingleDigitInput()
        {
            int sum = _numberOperation.Add("1");
            Assert.AreEqual(1, sum);
        }

        [TestMethod]
        public void TestSum_TestCommaSeparatedValue()
        {
            int sum = _numberOperation.Add("1,1");
            Assert.AreEqual(2, sum, "One plus one should be two");
        }

    }
}
