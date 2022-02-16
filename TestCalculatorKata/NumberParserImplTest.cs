using CalculatorTDDKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculatorKata
{
    [TestClass]
    public class NumberParserImplTest
    {
        NumberParserImpl _numberParserImpl;
        [TestInitialize]
        public void initialize()
        {
            _numberParserImpl = new NumberParserImpl();
        }
        [TestMethod]
        public void TestSum_TestBlankInput()
        {
            List<int> lstNumbers = _numberParserImpl.ParseSumNumbers("");
            Assert.AreEqual(0, lstNumbers.Count);
        }

        [TestMethod]
        public void TestSum_TestSingleDigitInput()
        {
            List<int> lstNumbers = _numberParserImpl.ParseSumNumbers("1");
            Assert.AreEqual(1, lstNumbers.Count);
            Assert.AreEqual(1, lstNumbers[0]);
        }

        [TestMethod]
        public void TestSum_TestCommaSeparatedValue()
        {
            List<int> lstNumbers = _numberParserImpl.ParseSumNumbers("1,2");
            Assert.AreEqual(2, lstNumbers.Count);
            Assert.AreEqual(1, lstNumbers[0]);
            Assert.AreEqual(2, lstNumbers[1]);
        }


        [TestMethod]
        public void TestSum_TestMultipleCommaSeparatedValues()
        {
            List<int> lstNumbers = _numberParserImpl.ParseSumNumbers("1,2,1,10");
            Assert.AreEqual(4, lstNumbers.Count);
            Assert.AreEqual(1, lstNumbers[0]);
            Assert.AreEqual(2, lstNumbers[1]);
            Assert.AreEqual(1, lstNumbers[2]);
            Assert.AreEqual(10, lstNumbers[3]);
        }

        [TestMethod]
        public void TestSum_TestMultipleNewLineCommaSeparatedValues()
        {
            List<int> lstNumbers = _numberParserImpl.ParseSumNumbers("1\n2,1,10");
            Assert.AreEqual(4, lstNumbers.Count);
            Assert.AreEqual(1, lstNumbers[0]);
            Assert.AreEqual(2, lstNumbers[1]);
            Assert.AreEqual(1, lstNumbers[2]);
            Assert.AreEqual(10, lstNumbers[3]);
        }


        [TestMethod]
        public void TestSum_TestCustomDelimeter()
        {
            List<int> lstNumbers = _numberParserImpl.ParseSumNumbers("//;\n1;2");
            Assert.AreEqual(2, lstNumbers.Count);
            Assert.AreEqual(1, lstNumbers[0]);
            Assert.AreEqual(2, lstNumbers[1]);
        }

        [TestMethod]
        public void TestSum_TestCustomDelimeterCanNotBemixedWithOthers()
        {
            Assert.ThrowsException<Exception>( () => _numberParserImpl.ParseSumNumbers("//;\n1;2,3"));
            
        }
    }
}
