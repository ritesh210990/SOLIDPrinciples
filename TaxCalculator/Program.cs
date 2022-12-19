
start();

void start()
{

    Console.WriteLine("Tax Calculator!");
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.WriteLine(Environment.NewLine);

    Console.WriteLine("Press 1 for Single Responsibility Principle (SRP)");
    Console.WriteLine("Press 2 for Open/Closed Principle (OCP)");
    Console.WriteLine("Press 3 for Liskov Substitution Principle (LSP)");
    Console.WriteLine("Press 4 for Interface Segregation Principle (ISP)");
    Console.WriteLine("Press 5 for Dependency Inversion Principle (DIP)");

    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("You selected option Single Responsibility Principle (SRP)");
            SRP();
            break;
        case "2":
            Console.WriteLine("You selected option Open/Closed Principle (OCP)");
            Console.WriteLine("Coming Soon !!");
            break;
        case "3":
            Console.WriteLine("You selected option Liskov Substitution Principle (LSP)");
            Console.WriteLine("Coming Soon !!");
            break;
        case "4":
            Console.WriteLine("You selected option Interface Segregation Principle (ISP)");
            Console.WriteLine("Coming Soon !!");
            break;
        case "5":
            Console.WriteLine("You selected option Dependency Inversion Principle (DIP)");
            Console.WriteLine("Coming Soon !!");
            break;

        default:
            Console.WriteLine("Wrong selection");
            break;
    }
}

void SRP()
{
    Console.WriteLine("Press 1 for SRP Bad code approach");
    Console.WriteLine("Press 2 for SRP correct code approach");

    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("You selected option SRP Bad code approach");
            var taxCalculator = new TaxCalculator.SRP.BadCodePractise.TaxCalculatorSRP();
            taxCalculator.Main();
            break;
        case "2":
            Console.WriteLine("You selected option SRP correct code approach");
            var taxCalculatorSRP = new TaxCalculator.SRP.CorrectCodePractise.TaxCalculatorSRP();
            taxCalculatorSRP.Main();
            break;

        default:
            Console.WriteLine("Wrong selection");
            break;
    }
}