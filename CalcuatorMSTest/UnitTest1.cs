using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorNS;

namespace CalcuatorMSTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestAdd()
        {    
            Assert.AreEqual(13, Calculator.Add(8, 5));
        }
        [TestMethod]
        public void TestMinus()
        {
            Assert.AreEqual(12, Calculator.Minus(15, 3));
        }
        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(2, Calculator.Divide(8, 4));          
        }
        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(12, Calculator.Multiply(6, 2));
        }

    }
}
