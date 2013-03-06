using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}", Math.Max(firstNumber, secondNumber));
    }
}
