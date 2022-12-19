namespace TaxCalculator.SRP.BadCodePractise
{
    public class TaxCalculatorSRP
    {
        public void Main()
        {
            Console.WriteLine("Enter total Income");
            decimal totalIncome = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter total HRA");
            decimal totalHRA = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter total 80C investment");
            decimal total80C = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter total home loan interest paid");
            decimal totalHomeLoanInterestPaid = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine($"Entered total income - {totalIncome}");
            Console.WriteLine($"Entered total HRA - {totalHRA}");
            Console.WriteLine($"Entered total 80C investment - {total80C}");
            Console.WriteLine($"Entered total home loan interest paid - {totalHomeLoanInterestPaid}");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Enter any key to calculate income tax");
            Console.ReadLine();

            var taxableIncome = totalIncome - (totalHRA + total80C + totalHomeLoanInterestPaid);
            Console.WriteLine($"Taxable income - {taxableIncome}");

            decimal tax = 0;
            if (taxableIncome > 1000000)
            {
                decimal firstSlabTax = 12500;
                decimal secondSlabTax = 100000;
                decimal thirdSlabTax = (taxableIncome - 1000000) * 30 / 100;
                tax = firstSlabTax + secondSlabTax + thirdSlabTax;
            }
            else if (taxableIncome >= 500001 && taxableIncome <= 1000000)
            {
                decimal firstSlabTax = 12500;
                decimal secondSlabTax = (taxableIncome - 500000) * 20 / 100;
                tax = firstSlabTax + secondSlabTax;
            }
            else if (taxableIncome >= 250001 && taxableIncome <= 500000)
            {
                tax = (taxableIncome - 250000) * 5 / 100;
            }

            Console.WriteLine($"Total tax to be paid - {tax}");
        }
    }
}