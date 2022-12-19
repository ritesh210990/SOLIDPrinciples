namespace TaxCalculator.SRP.CorrectCodePractise
{
    public class TaxCalculatorSRP
    {
        public void Main()
        {
            var userInput = CollectInput();

            PrintInput(userInput);

            StartTaxCalculation(userInput);
        }

        UserInput CollectInput()
        {
            Console.WriteLine("Enter total Income");
            decimal totalIncome = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter total HRA");
            decimal totalHRA = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter total 80C investment");
            decimal total80C = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter total home loan interest paid");
            decimal totalHomeLoanInterestPaid = decimal.Parse(Console.ReadLine());

            return new UserInput(totalIncome, totalHRA, total80C, totalHomeLoanInterestPaid);
        }

        void PrintInput(UserInput userInput)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine($"Entered total income - {userInput.TotalIncome}");
            Console.WriteLine($"Entered total HRA - {userInput.TotalHRA}");
            Console.WriteLine($"Entered total 80C investment - {userInput.Total80C}");
            Console.WriteLine($"Entered total home loan interest paid - {userInput.TotalHomeLoanInterestPaid}");

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-------------------------------------------------------------------");
        }

        void StartTaxCalculation(UserInput userInput)
        {
            Console.WriteLine("Enter any key to calculate income tax");
            Console.ReadLine();

            var taxableIncome = userInput.TotalIncome - (userInput.TotalHRA + userInput.Total80C + userInput.TotalHomeLoanInterestPaid);
            Console.WriteLine($"Taxable income - {taxableIncome}");

            var tax = CalculateTax(taxableIncome, 0);
            Console.WriteLine($"Total tax to be paid - {tax}");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        decimal CalculateTax(decimal taxableIncome, decimal tax)
        {
            decimal thirdSlabStartAmt = 1000000;
            decimal secondSlabStartAmt = 500000;
            decimal firstSlabStartAmt = 250000;

            if (taxableIncome > thirdSlabStartAmt)
            {
                tax += GetTaxableAmount((taxableIncome - thirdSlabStartAmt), 30);
                taxableIncome = thirdSlabStartAmt;
            }
            else if (taxableIncome > secondSlabStartAmt && taxableIncome <= thirdSlabStartAmt)
            {
                tax += GetTaxableAmount((taxableIncome - secondSlabStartAmt), 20);
                taxableIncome = secondSlabStartAmt;
            }
            else if (taxableIncome > firstSlabStartAmt && taxableIncome <= secondSlabStartAmt)
            {
                tax += GetTaxableAmount((taxableIncome - firstSlabStartAmt), 5);
                return tax;
            }

            return CalculateTax(taxableIncome, tax);
        }

        decimal GetTaxableAmount(decimal amt, decimal percentage)
        {
            return amt * percentage / 100;
        }

    }
}
