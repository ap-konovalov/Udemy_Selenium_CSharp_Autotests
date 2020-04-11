using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5
{
    [TestClass]
    public class DecimalOperations
    {
        static decimal number1;
        static decimal number2;

        [ClassInitialize]
        public static void FloatInitializer(TestContext testContext)
        {
            number1 = 10.5M;
            number2 = 5.0M;
        }


        [TestMethod]
        public void Addition()
        {
            decimal sum = number1 + number2;
            Assert.AreEqual(15.5M, sum);
        }

        [TestMethod]
        public void Subtraction()
        {
            decimal difference = number1 - number2;
            Assert.AreEqual(5.5M, difference);
        }

        [TestMethod]
        public void Multiplication()
        {
            decimal product = number1 * number2;
            Assert.AreEqual(52.5M, product);
        }

        [TestMethod]
        public void Division()
        {
            decimal quotient = number1 / number2;
            Assert.AreEqual(2.1M, quotient);
        }

        [TestMethod]
        public void Modules()
        {
            decimal remaider = number1 % number2;
            Assert.AreEqual(0.5M, remaider);
        }

    }
}
