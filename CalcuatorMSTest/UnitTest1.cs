using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorNS;

namespace CalcuatorMSTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator clc;
        [TestInitialize]
        public void Initialize()
        {
            clc = new Calculator();
        }
        [TestMethod]
        public void TestAdd()
        {    
            Assert.AreEqual(13, clc.Add(8, 5));
        }
        [TestMethod]
        public void TestMinus()
        {
            Assert.AreEqual(12, clc.Minus(15, 3));
        }
        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(2, clc.Divide(8, 4));          
        }
        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(12, clc.Multiply(6, 2));
        }

        [TestCleanup]
        public void CleanUpMethod()
        {
            clc = null;
        }
    }
}
