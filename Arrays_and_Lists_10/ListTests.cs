using System;
using System.Collections;
using NUnit.Framework;

namespace Arrays_and_Lists_10
{
    public class ListTests
    {
        [Test]
        public void Creating_List()
        {
            ArrayList testArray = new ArrayList();
            testArray.Add("Today");
            testArray.Add(2);
            testArray.Add(20);
            testArray.Add(20M);
            Console.WriteLine(testArray.Count);

            testArray.RemoveAt(3);
            Console.WriteLine(testArray.Count);
        }

        [Test]
        public void Testing_ArrayList()
        {
            ArrayList scores = new ArrayList();
            FillList(scores);
            int sum = TotalScores(scores);
            Console.WriteLine(sum);
        }

        [Test]
        public void ArrayList_Practice()
        {
            ArrayList list = new ArrayList();

            list.Add(25);
            list.Add(10);

            Console.WriteLine($"Capacity: {list.Capacity}");
            Console.WriteLine($"Count: {list.Count}");
        }

        private int TotalScores(ArrayList scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            return sum;
        }

        private void FillList(ArrayList scores)
        {
            for (int i = 0; i <= 20; i++)
            {
                scores.Add(i);
            }
        }
    }
}