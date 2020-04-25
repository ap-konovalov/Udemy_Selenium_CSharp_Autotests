using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods_9.SectionExam
{
    [TestClass]
    public class PropertyTaxCalculatorTests
    {
        [TestMethod]
        public void PropertyTaxCalculator_CanReturn_CurrentAssessedValue()
        {
            const decimal propertyAssessedValue = 27000M;
            const decimal increaseValue = 0.027M;
            
            PropertyTaxCalculator calculatorForMoscow = new PropertyTaxCalculator("Moscow", propertyAssessedValue);

            var expectedAssessedValue = propertyAssessedValue * increaseValue + propertyAssessedValue;
            var actualAssessedValue = calculatorForMoscow.returnCurrentAssessedValue();
            
            Assert.AreEqual(expectedAssessedValue, actualAssessedValue); 

            Console.WriteLine(calculatorForMoscow.ToString());
        }       
        
        [TestMethod]
        public void PropertyTaxCalculator_CanCalculateCurrentYearTax()
        {
            const decimal propertyAssessedValue = 27000M;
            const decimal millageRatePerEvery1000 = 10.3M;
            
            PropertyTaxCalculator calculatorForMoscow = new PropertyTaxCalculator("Moscow", propertyAssessedValue);
            
            
            var expectedCurrentYearTax = Math.Truncate(calculatorForMoscow.TaxableValue / 1000) * millageRatePerEvery1000;
            var actualCurrentYearTax = calculatorForMoscow.CalculateCurrentYearTax();
            
            Assert.AreEqual(expectedCurrentYearTax, actualCurrentYearTax);
        }

        [TestMethod]
        public void PropertyTaxCalculator_CanShowAsString()
        {
            PropertyTaxCalculator calculatorForMoscow = new PropertyTaxCalculator("Moscow", 25000M);
            PropertyTaxCalculator calculatorForSamara = new PropertyTaxCalculator("Samara", 29000M);
            PropertyTaxCalculator calculatorForSochi = new PropertyTaxCalculator("Sochi", 35000M);

            Console.WriteLine(calculatorForMoscow.ToString() + calculatorForSamara.ToString() + calculatorForSochi.ToString());
        }
    }
}