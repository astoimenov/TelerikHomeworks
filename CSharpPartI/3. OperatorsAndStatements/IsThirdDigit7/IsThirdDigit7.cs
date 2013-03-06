using System;

class IsThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);
        int thirdDigit = (number / 100) % 10;
        if (thirdDigit == 7)
        {
            Console.WriteLine("The third digit is 7!");
        }
        else
        {
            Console.WriteLine("The third digt is not 7!");
        }
    }
}
