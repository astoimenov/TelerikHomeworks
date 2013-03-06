using System;

class PrintAge
{
    static void Main()
    {
        Console.WriteLine("Enter your age");
        Console.WriteLine();
        int age = int.Parse(Console.ReadLine());
        DateTime ageNow = new DateTime(age,1,1);
        ageNow = ageNow.AddYears(10);
        Console.WriteLine("Your age is ");
        Console.WriteLine(ageNow.Year);
    }
}
