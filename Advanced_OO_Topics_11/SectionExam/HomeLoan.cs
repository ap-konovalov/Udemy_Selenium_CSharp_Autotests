using System;

namespace Advanced_OO_Topics_11.SectionExam
{
    public class HomeLoan : Loan
    {
        private string _address;
        private int _yearBuild;
        private double _squareFootage;
        private decimal _adminFee = 5000;

        public HomeLoan(int loanNumber,
            string customerFirstName,
            string customerLastName,
            double interestRate,
            decimal loanAmount,
            int loanPeriodInYears,
            string address,
            int yearBuild,
            double squareFootage
        )
            : base(loanNumber, customerFirstName, customerLastName, interestRate, loanAmount, loanPeriodInYears)
        {
            _address = address;
            _yearBuild = yearBuild;
            _squareFootage = squareFootage;
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
                   $"Address: {_address}\n" +
                   $"Year of build: {_yearBuild}\n" +
                   $"Square footage: {_squareFootage}";
        }
    }
}