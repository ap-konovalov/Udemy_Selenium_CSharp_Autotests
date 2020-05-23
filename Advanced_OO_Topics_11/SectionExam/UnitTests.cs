using System;
using NUnit.Framework;

namespace Advanced_OO_Topics_11.SectionExam
{
    public class UnitTests
    {
        [Test]
        public void WhenCreateAutoLoanAndCalculateInterest_ThenInterestShouldCalculatedCorrect()
        {
            var expectedInterest = 2925M;
            AutoLoan mazdaLoan = new AutoLoan(1, 
                "Petrov", 
                "Petr", 
                7.5, 
                12000,
                4,
                2018, 
                "3", 
                "Mazda", 
                "Blue");
            
            var actualInterest = mazdaLoan.CalculateInterest();

            Assert.AreEqual(expectedInterest, actualInterest);
            
            Console.WriteLine(mazdaLoan.ToString());
        } 
        
        [Test]
        public void WhenCreateHomeLoanAndCalculateInterest_ThenInterestShouldCalculatedCorrect()
        {
            var expectedInterest = 3010M;
            HomeLoan kremlin = new HomeLoan(1, 
                "Petrov", 
                "Petr", 
                3.5, 
                210000,
                30,
                "Moscow, Kremlin", 
                1180, 
                40.65);
            
            var actualInterest = kremlin.CalculateInterest();

            Assert.AreEqual(expectedInterest, actualInterest);
            Console.WriteLine(kremlin.ToString());
        }
    }
}