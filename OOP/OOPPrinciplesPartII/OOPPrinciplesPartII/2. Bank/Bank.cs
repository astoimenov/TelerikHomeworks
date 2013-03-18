using System;

class Bank
{
    static void Main()
    {
        Acount[] bankAcounts = { new Deposit(new IndividualCustomer("Stanislava Yaneva", "0883565674", "9103122869"),2545.50, 0.3),
                                   new Loan(new CompanyCustomer("TU Sofia OOD", "9653435", "Asen Sirakov"), 20000, 0.2),
                                   new Mortgage(new IndividualCustomer("Elica Lazarova", "088467910", "9301266938"), 1534.35, 0.4)};

        Console.WriteLine("All Acounts:\n");
        PrintAcounts(bankAcounts);

        Console.WriteLine("\nAcounts after 500 deposit:\n");
        foreach (IDepositable acount in bankAcounts)
        {
            acount.Deposit(500);
        }

        PrintAcounts(bankAcounts);

        Console.Write("\nEnter number of months for interest: ");
        int months = int.Parse(Console.ReadLine());

        foreach (IInterestable acount in bankAcounts)
        {
            Console.WriteLine("The {0} has interest: {1}", acount.GetType().Name, acount.CalculateInterestAmount(months));
        }
    }
    static void PrintAcounts(Acount[] acounts)
    {
        foreach (IPrintable acount in acounts)
        {
            acount.PrintInfo();
        }
    }
}