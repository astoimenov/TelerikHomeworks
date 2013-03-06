using System;

class CompanyData
{
    static void Main()
    {
        Console.WriteLine("Enter the data of the company:");
        Console.Write("Name: ");
        string compName = Console.ReadLine();
        Console.Write("Address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string compPhone = Console.ReadLine();
        Console.Write("Fax number: ");
        string compFax = Console.ReadLine();
        Console.Write("Web site: ");
        string compWebSite = Console.ReadLine();
        Console.Write("Manager: ");
        string compManager = Console.ReadLine();

        Console.WriteLine("Enter the data for the manager:");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(compName);
        Console.WriteLine();
        Console.WriteLine("Address: {0}", compAddress);
        Console.WriteLine("Phone number: {0}; Fax number: {1}", compPhone, compFax);
        Console.WriteLine("Web site: {0}", compWebSite);
        Console.WriteLine("Manager: {0}", compManager);

        Console.WriteLine();
        Console.WriteLine("Manager`s data:");
        Console.WriteLine();
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Phone number: {0}", managerPhone);
    }
}
