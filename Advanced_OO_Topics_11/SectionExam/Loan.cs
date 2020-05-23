namespace Advanced_OO_Topics_11.SectionExam
{
    public abstract class Loan
    {
       private int _loanNumber;
        private string _customerFirstName;
        private string _customerLastName;
        protected double interestRate;
        protected decimal loanAmount;
        protected int loanPeriodInYears;
        protected decimal calculatedInterest;
                
        protected Loan(int loanNumber, 
            string customerFirstName, 
            string customerLastName, 
            double interestRate, 
            decimal loanAmount, 
            int loanPeriodInYears)
        {
            _loanNumber = loanNumber;
            _customerFirstName = customerFirstName;
            _customerLastName = customerLastName;
            this.interestRate = interestRate;
            this.loanAmount = loanAmount;
            this.loanPeriodInYears = loanPeriodInYears;
            calculatedInterest = 0;
        }

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return $"Loan number: {_loanNumber}\n" +
                   $"Customer First Name: {_customerFirstName}\n" +
                   $"Customer Last Name: {_customerLastName}\n" +
                   $"Interest Rate: {interestRate} %\n" +
                   $"Loan Amount: {loanAmount} $\n" +
                   $"Number of Years in the loan’s term: {loanPeriodInYears}\n" +
                   $"Calculated interest: {calculatedInterest:F2} $\n";
        }
    }
}