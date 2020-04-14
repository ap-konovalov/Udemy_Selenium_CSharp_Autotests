using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repetition_8
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void Strange_Foor_Loops()
        {
            for (int counter = 0, val1 = 10; counter < val1; counter++)
            {
            }

            int count2 = 0;
            for (; count2 < 100; count2 += 10)
            {
            }

            for (int j = 0;; j++)
            {
            }

            for (double d = 15.0; d < 20.0; d += 0.5)
            {
            }
        }
    }
}