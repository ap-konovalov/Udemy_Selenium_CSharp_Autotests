using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods_9.CodingQuiz
{
    [TestClass]
    public class TestMathFunctions
    {
        [TestMethod]
        public void WhenCallSquareRootHelper_ThenReturnSqare()
        {
            double number = 9.00;

            var result = MathFunctions.SquareRoot(number);

            Assert.AreEqual(3.00, result);
        }

        [TestMethod]
        public void WhenCallSumHelperWithIntegers_ThenReturtThemSum()
        {
            var result = MathFunctions.Sum(1, 2);

            Assert.AreEqual(3, result);
        }
        
        [TestMethod]
        public void WhenCallSumHelperWithDoubles_ThenReturtThemSum()
        {
            var result = MathFunctions.Sum(1.5, 2.5);

            Assert.AreEqual(4.00, result);
        }
        
        [TestMethod]
        public void WhenCallSumHelperWithDecimals_ThenReturtThemSum()
        {
            var result = MathFunctions.Sum(3.2M, 2.8M);

            Assert.AreEqual(6.0M, result);
        }
    }
}