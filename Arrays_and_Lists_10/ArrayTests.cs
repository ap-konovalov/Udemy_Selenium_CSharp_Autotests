using System;
using System.Diagnostics;
using NUnit.Framework;

namespace Arrays_and_Lists_10
{
    public class ArrayTests
    {
        [Test]
        public void Array_Test()
        {
            int[] scores = new int[5];

            scores[0] = 5;
            int firstScore = scores[0];

            Assert.AreEqual(5, scores[0]);
            Assert.AreEqual(5, firstScore);

            int numPositions = 3;
            int[] myArray = new int[numPositions];

            Assert.AreEqual(3, myArray.Length);
        }

        [Test]
        public void ForEach_Loop_Test()
        {
            int[] scores = {5, 3, 4, 2};

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        [Test]
        public void Pass_Array_Method()
        {
            int[] scores = new[] {5, 3, 4, 2};
            int sum = TotalScores(scores);

            Assert.AreEqual(5 + 3 + 4 + 2, sum);
        }

        int TotalScores(int[] scores)
        {
            int sum = 0;
            foreach (var score in scores)
            {
                sum += score;
            }

            return sum;
        }

        [Test]
        public void Pass_Array_Element()
        {
            int[] scores = {5, 4, 5, 3, 2};
            foreach (var score in scores)
            {
                Console.WriteLine(CheckScore(score));
            }

            string CheckScore(int score)
            {
                switch (score)
                {
                    case 5:
                        return "Excelense";
                    case 4:
                        return "Good job";
                    case 3:
                        return "You can do better";
                    default:
                        return "Bad";
                }
            }
        }

        [Test]
        public void Array_Class_Methods()
        {
            double[] waterDepth = {12.4, 5.6, 3.2};

            Array.Sort(waterDepth);

            foreach (var depthVal in waterDepth)
            {
                Console.Write(depthVal + "\t");
            }

            Assert.AreEqual(3.2, waterDepth[0]);

            Console.WriteLine("\nReverse");

            Array.Reverse(waterDepth);

            foreach (var depthVal in waterDepth)
            {
                Console.Write(depthVal + "\t");
            }

            Assert.AreEqual(12.4, waterDepth[0]);
        }
    }
}