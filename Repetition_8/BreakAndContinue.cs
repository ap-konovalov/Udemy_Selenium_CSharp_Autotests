using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repetition_8
{
    [TestClass]
    public class BreakAndContinue
    {
        [TestMethod]
        public void Break_Keyword()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine($"Loop iteration: '{i}'. Next command in loop block is 'break'");
                    break;
                }

                Console.WriteLine($"End of loop iteration: '{i}'. Total loops amount: 10");
            }
            Console.WriteLine($"Out of loop statements");
        }
        
        [TestMethod]
        public void Continue_Keyword()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Begin of loop number: '{i}'.");
                
                if (i == 1)
                {
                    Console.WriteLine($"Loop iteration: '{i}'. Next command in loop block is 'continue'");
                    continue;
                }

                Console.WriteLine($"End of loop iteration: '{i}'.");
            }
            Console.WriteLine($"Out of loop statements");
        }
    }
}