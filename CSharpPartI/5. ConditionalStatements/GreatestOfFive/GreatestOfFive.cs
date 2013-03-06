using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        double greatestNumber = firstNumber;
        if (greatestNumber < secondNumber)
        {
            greatestNumber = secondNumber;
        }
        if (greatestNumber < thirdNumber)
        {
            greatestNumber = thirdNumber;
        }
        if (greatestNumber < fourthNumber)
        {
            greatestNumber = fourthNumber;
        }
        if (greatestNumber < fifthNumber)
        {
            greatestNumber = fifthNumber;
        }
        Console.WriteLine("The greatest number is: {0}", greatestNumber);
    }

}
