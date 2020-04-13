using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repetition_8
{
    [TestClass]
    public class Operators
    {
        [TestMethod]
        public void Increment_Prefix()
        {
            int number = 1;
            Assert.AreEqual(2, ++number);
        }
        
        [TestMethod]
        public void Increment_Postfix()
        {
            int number = 1;
            Assert.AreEqual(1, number++);
            Assert.AreEqual(2, number);
        }
    }
}