using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5
{
    [TestClass]
    public class EqalityAndRelationsheep
    {
        private static int number1;
        private static int number2;

        [ClassInitialize]
        public static void EqalityAndRelationsheepIntializer(TestContext testContext)
        {
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Number1_IsEqual_Number2()
        {
            Assert.IsTrue(number1 == number2);
        }

        [TestMethod]
        public void Number1_IsNotEqual_Number2()
        {
            Assert.IsTrue(number1 != number2);
        }

        [TestMethod]
        public void Number1_Greater_Than_Number2()
        {
            Assert.IsTrue(number1 > number2);
        }

        [TestMethod]
        public void Number1_Greater_Than_Or_Equal_Number2()
        {
            Assert.IsTrue(number1 >= number2);
        }

        [TestMethod]
        public void Number1_Less_Than_Number2()
        {
            Assert.IsTrue(number1 < number2);
        }

        [TestMethod]
        public void Number1_Less_Than_Or_Equal_Number2()
        {
            Assert.IsTrue(number1 <= number2);
        }

    }
}
