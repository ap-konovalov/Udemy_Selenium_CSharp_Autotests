using System;

namespace Advanced_OO_Topics_11.SectionExam
{
    public class AutoLoan : Loan
    {
        private int _yearOfBuild;
        private string _model;
        private string _make;
        private string _colour;
        private decimal _adminFee = 1000;

        public AutoLoan(int loanNumber,
            string customerFirstName,
            string customerLastName,
            double interestRate,
            decimal loanAmount,
            int loanPeriodInYears,
            int yearOfBuild,
            string model,
            string make,
            string colour)
            : base(loanNumber, customerFirstName, customerLastName, interestRate, loanAmount, loanPeriodInYears)
        {
            _yearOfBuild = yearOfBuild;
            _model = model;
            _make = make;
            _colour = colour;
        }
        
        public override decimal CalculateInterest()
        {
            var loanPrincipal = loanAmount + _adminFee;
            calculatedInterest = Convert.ToDecimal(interestRate / 100) / Convert.ToDecimal(loanPeriodInYears / 12M) *
                                  loanPrincipal;
            return calculatedInterest;
        }

        public override string ToString()
        {
            return base.ToString() + 
                   $"Year of built: {_yearOfBuild}\n" +
                   $"Model: {_model}\n" +
                   $"Make: {_make}\n" +
                   $"Colour: {_colour}";
        }
    }
}