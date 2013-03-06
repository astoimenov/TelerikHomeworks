using System;

class FullName
{
    static void Main()
    {
        string firstName;
        string lastName;
        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Full Name: {0} {1}\n", firstName, lastName);
    }
}
