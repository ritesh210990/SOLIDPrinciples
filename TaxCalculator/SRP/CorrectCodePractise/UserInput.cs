namespace TaxCalculator.SRP.CorrectCodePractise
{
    internal class UserInput
    {
        public UserInput(decimal totalIncome, decimal totalHRA, decimal total80C, decimal totalHomeLoanInterestPaid)
        {
            TotalIncome = totalIncome;
            TotalHRA = totalHRA;
            Total80C = total80C;
            TotalHomeLoanInterestPaid = totalHomeLoanInterestPaid;
        }

        public decimal TotalIncome;
        public decimal TotalHRA;
        public decimal Total80C;
        public decimal TotalHomeLoanInterestPaid;
    }
}
