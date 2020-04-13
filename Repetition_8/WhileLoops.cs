using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repetition_8
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void While_Loops()
        {
            int counter = 1;
            int enteriesInTheCicle = 0;

            while (counter < 4)
            {
                counter++;
                enteriesInTheCicle++;
            }

            Assert.AreEqual(3, enteriesInTheCicle);
        }

        [TestMethod]
        public void Sentinel_Controlled_Loops()
        {
            string finishLoopValue = String.Empty;

            while (finishLoopValue != "stop")
            {
                Console.WriteLine("Write 'stop' to exit");
                finishLoopValue = Console.ReadLine();
            }
        }

        [TestMethod]
        public void Nested_Loops()
        {
            int firstCondition = 1;
            int secondCondition = 1;

            while (firstCondition < 4)
            {
                Console.WriteLine($"Outer loop called {firstCondition}");
                while (secondCondition < 4)
                {
                    Console.WriteLine($"Inner loop called {secondCondition}");

                    secondCondition++;
                }

                firstCondition++;
            }
        }

        [TestMethod]
        public void Nested_Loops_Practice()
        {
            int outerLoopCounter = 0;


            while (outerLoopCounter < 3)
            {
                int innerLoolCounter = 10;

                while (innerLoolCounter > 5)
                {
                    Console.WriteLine($"Outer: {outerLoopCounter} \t Inner: {innerLoolCounter}");
                    innerLoolCounter--;
                }

                outerLoopCounter++;
            }
        }
    }
}