using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repetition_8
{
    [TestClass]
    public class DoWhile
    {
        [TestMethod]
        public void DoWhileLoops()
        {
            int number = 1;
            do
            {
                number++;
            } while (number <= 1);
            
            Assert.AreEqual(2,number);
        }
    }
}