using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods_9
{
    [TestClass]
    public class MathClassTest
    {
        [TestMethod]
        public void Call_Square_Static_Method()
        {
            int number = 10;
            int squareOfNumber = MathClass.Square(number);
            
            Assert.AreEqual(100, squareOfNumber);
        }
    }
}
