using System;

namespace Array_Coding_Quiz_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input;
            int[] numCounter = new int[11];
            var invalidNumberEntries = 0;
            var notNumberEntries = 0;

            Console.WriteLine("Press 'q' to exit");
            do
            {
                input = Console.ReadLine();

                try
                {
                    var enteredNumber = Convert.ToInt32(input);

                    if (enteredNumber <= numCounter.Length -1 && enteredNumber >= 0)
                    {
                        numCounter[enteredNumber]++;
                    }
                    else
                    {
                        Console.WriteLine("Number should be >= 0 and <= 10");
                        invalidNumberEntries++;
                    }
                }
                catch
                {
                    if (input != "q")
                    {
                        Console.WriteLine("You should enter number between 0 and 10");
                        notNumberEntries++;
                    }
                }
            } while (input != "q");

            DisplayResult(numCounter, invalidNumberEntries, notNumberEntries);
        }

        private static void DisplayResult(int[] numCounter, int invalidNumberEntries, int notNumberEntries)
        {
            var number = 0;
            foreach (var countOfEntered in numCounter)
            {
                if (countOfEntered > 0)
                {
                    Console.WriteLine($"Number\t '{number}' \tentered\t '{countOfEntered}' times");
                }

                number++;
            }

            Console.WriteLine($"Invalid number entries count: {invalidNumberEntries}");
            Console.WriteLine($"Not number entries count: {notNumberEntries}");
        }
    }
}