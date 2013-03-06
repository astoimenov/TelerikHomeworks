using System;

class Program
{
    static void Main()
    {
        Console.Write("First number = ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number = ");
        int secondNumber = int.Parse(Console.ReadLine());

        int temp1, temp2;
        temp1 = secondNumber;
        while (temp1 != 0)
        {
            temp2 = firstNumber % temp1;
            firstNumber = temp1;
            temp1 = temp2;
        }
        Console.WriteLine("The greatest common divisor is = " + firstNumber);
    } 
}
