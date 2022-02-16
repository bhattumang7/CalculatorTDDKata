using CalculatorTDDKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculatorKata
{
    [TestClass]
    public class NumberOperationsTest
    {
        NumberOperation _numberOperation = null;
        NumberParser _numberParser = null;
        [TestInitialize]
        public void InitializeTest()
        {
            _numberParser = new NumberParserImpl();
            _numberOperation = new NumberOperation(_numberParser);
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


        [TestMethod]
        public void TestSum_TestMultipleCommaSeparatedValues()
        {
            int sum = _numberOperation.Add("1,1,1,10");
            Assert.AreEqual(13, sum, "One plus one plus one plus ten should be thriteen");
        }

    }
}
