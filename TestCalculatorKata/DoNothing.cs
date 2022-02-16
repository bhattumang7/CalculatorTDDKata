using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculatorKata
{
    [TestClass]
    public class DoNothing
    {
        [TestMethod]
        public void ConfirmEnvironmentWokring()
        {
            Assert.IsTrue(true, "If this fails, environment is not up");
        }
    }
}
