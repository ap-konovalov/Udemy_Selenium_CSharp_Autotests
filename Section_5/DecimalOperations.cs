using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5
{
    [TestClass]
    public class FloatingPointOperations
    {
        static double number1;
        static double number2;

        [ClassInitialize]
        public static void FloatInitializer(TestContext testContext)
        {
            number1 = 10.5;
            number2 = 5.0;
        }


        [TestMethod]
        public void Addition()
        {
            double sum = number1 + number2;
            Assert.AreEqual(15.5, sum);
        }

        [TestMethod]
        public void Subtraction()
        {
            double difference = number1 - number2;
            Assert.AreEqual(5.5, difference);
        }

        [TestMethod]
        public void Multiplication()
        {
            double product = number1 * number2;
            Assert.AreEqual(52.5, product);
        }

        [TestMethod]
        public void Division()
        {
            double quotient = number1 / number2;
            Assert.AreEqual(2.1, quotient);
        }

        [TestMethod]
        public void Modules()
        {
            double remaider = number1 % number2;
            Assert.AreEqual(0.5, remaider);
        }

    }
}
