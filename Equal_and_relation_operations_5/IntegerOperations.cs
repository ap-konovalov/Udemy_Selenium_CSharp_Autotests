using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section_5
{
    [TestClass]
    public class IntegerOperations
    {
        static int ten;
        static int five;

        [ClassInitialize]
        public static void IntegerIntializer(TestContext testContext)
        {
            ten = 10;
            five = 5;
        }


        [TestMethod]
        public void Addition()
        {
            int sum = ten + five;
            Console.WriteLine(sum);
            Assert.AreEqual(15, sum);
        }

        [TestMethod]
        public void Subtraction()
        {
            int difference = ten - five;
            Assert.AreEqual(5, difference);
        }

        [TestMethod]
        public void Multiplication()
        {
            int product = ten * five;
            Assert.AreEqual(50, product);
        }

        [TestMethod]
        public void Division()
        {
            int quotient = ten / five;
            Assert.AreEqual(2, quotient);
        }

        [TestMethod]
        public void Modules()
        {
            int remaider = ten % five;
            Assert.AreEqual(0, remaider);
        }
    }
}
