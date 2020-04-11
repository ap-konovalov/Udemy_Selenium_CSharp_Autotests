using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5
{
    [TestClass]
    public class SectionQueez
    {
        private double _expectedFahrenheit;
        private double _expectedCelsius;

        [TestInitialize]
        public void expectedValuse()
        {
            _expectedFahrenheit = 57.0;
            _expectedCelsius = 13.89;
        }

        [TestMethod]
        public void Convert_F_To_C()
        {
            double convertFtoC (double fahrenheit)
            {
                return (fahrenheit - 32) * .5556;
            }

            Assert.AreEqual(_expectedCelsius, convertFtoC(_expectedFahrenheit), 0.001);
        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            double convertCtoF(double celsius)
            {
                return (celsius * 1.8) + 32;
            }

            Assert.AreEqual(_expectedFahrenheit, convertCtoF(_expectedCelsius), 0.01);
        }
    }
}
