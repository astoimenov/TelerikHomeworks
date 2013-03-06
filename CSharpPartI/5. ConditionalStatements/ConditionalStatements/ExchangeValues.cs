using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int num = 0;
        if (firstNumber > secondNumber)
        {
            num = firstNumber;
            firstNumber = secondNumber;
            secondNumber = num;
            Console.WriteLine("First number: {0}", firstNumber);
            Console.WriteLine("Second number: {0}", secondNumber);
        }
    }
}
