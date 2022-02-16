using CalculatorTDDKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Telerik.JustMock;

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
            _numberParser = Mock.Create<NumberParser>();
            _numberOperation = new NumberOperation(_numberParser);
        }
        [TestMethod]
        public void TestSum_TestBlankInput()
        {
            string input = "";
            List<int> lstNumbers = new List<int>();
            Mock.Arrange(() => _numberParser.ParseSumNumbers(input)).Returns(lstNumbers);
            int sum = _numberOperation.Add("input");
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        public void TestSum_TestMultipleCommaSeparatedValues()
        {
            string input = "1,10,100";
            List<int> lstNumbers = new List<int>();
            lstNumbers.Add(1);
            lstNumbers.Add(10);
            lstNumbers.Add(100);
            Mock.Arrange(() => _numberParser.ParseSumNumbers(input)).Returns(lstNumbers);
            int sum = _numberOperation.Add(input);
            Assert.AreEqual(111, sum);
        }



        [TestMethod]
        public void TestSum_TestNegativeValues()
        {
            string input = "1,10,100";
            List<int> lstNumbers = new List<int>();
            lstNumbers.Add(1);
            lstNumbers.Add(10);
            lstNumbers.Add(-5);
            lstNumbers.Add(6);
            lstNumbers.Add(-10);
            Mock.Arrange(() => _numberParser.ParseSumNumbers(input)).Returns(lstNumbers);
            var exception = Assert.ThrowsException<ArgumentException>(() => _numberOperation.Add(input));
            Assert.IsTrue(exception.Message.Contains("-5"));
            Assert.IsTrue(exception.Message.Contains("-10"));
        }
    }
}
