using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repetition_8
{
    [TestClass]
    public class SwitchState
    {
        [TestMethod]
        public void Switch_Statements()
        {
            int dayOfWeek = 2;
            string testDay;

            switch (dayOfWeek)
            {
                case 1:
                    testDay = "Monday";
                    break;
                case 2:
                    testDay = "Thursday";
                    break;
                default:
                    testDay = "Not Monday of Thursday";
                    break;
            }
            
            Assert.AreEqual("Thursday", testDay);
        }

        [TestMethod]
        public void Switch_Country()
        {
            string countryCode = "RU";
            string counrtyName = String.Empty;
            
            switch (countryCode)
            {
                case "RU":
                    counrtyName = "Russia";
                    break;
                case "GB":
                    counrtyName = "Great Britan";
                    break;
            }
            
            Assert.AreEqual("Russia", counrtyName);
        }
    }
}