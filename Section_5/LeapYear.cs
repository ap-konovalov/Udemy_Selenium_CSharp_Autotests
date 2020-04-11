using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5
{
    [TestClass]
    public class LeapYear
    {
        private static string _isDivisibleBy4;
        private static string _isDivisibleBy100;
        private static string _isDivisibleBy400;
        private static string _isLeapYear;
        private static bool _isOddYear;
        private static int _year;

        [TestInitialize]
        public void LeapYearInitializer()
        {
            _isDivisibleBy4 = "No";
            _isDivisibleBy100 = "No";
            _isDivisibleBy400 = "No";
            _isLeapYear = "No";
        }

        [TestMethod]
        public void Not_Leat_Year_1234()
        {
            var result = IsLeapYear(1234);
            Assert.AreEqual("No", result);
        }

        [TestMethod]
        public void Leat_Year_2000()
        {
            var result = IsLeapYear(2000);
            StringAssert.Equals("Yes", result);
        }

        public string IsLeapYear(int year)
        {
            _year = year;

            Console.WriteLine($"Entered year: {_year}");

            if (_year % 4 == 0)
            {
                _isDivisibleBy4 = "Yes";

            }

            if (_year % 100 == 0)
            {
                _isDivisibleBy100 = "Yes";

            }

            if (_year % 400 == 0)
            {
                _isDivisibleBy400 = "Yes";
            }

            if (_year % 2 == 0)
            {
                _isOddYear = false;
            }
            else
            {
                _isOddYear = true;
            }

            if (
                _isDivisibleBy4 == "Yes" &&
                _isDivisibleBy100 == "Yes" &&
                _isDivisibleBy400 == "Yes" &&
                !_isOddYear)
            {
                _isLeapYear = "Yes";
            }
            else if (
                _isDivisibleBy4 == "Yes" &&
                _isDivisibleBy100 == "No" &&
                _isDivisibleBy400 == "No" &&
                !_isOddYear)
            {
                _isLeapYear = "Yes";
            }

            Console.WriteLine($"Divisible by 4: {_isDivisibleBy4}");
            Console.WriteLine($"Divisible by 100: {_isDivisibleBy100}");
            Console.WriteLine($"Divisible by 400: {_isDivisibleBy400}");
            Console.WriteLine($"Leap Year: {_isLeapYear}");

            return _isLeapYear;
        }
    }
}
