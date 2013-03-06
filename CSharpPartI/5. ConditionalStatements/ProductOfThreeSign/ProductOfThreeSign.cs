using System;

class ProductOfThreeSign
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int thirdNum = int.Parse(Console.ReadLine());

        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
            {
                Console.WriteLine("The product of the numbers is zero!");
            }
            else
            {
                bool positive = true;
                if(firstNum<0)
                {
                    positive = !positive;
                }
                if(secondNum<0)
                {
                    positive = !positive;
                }
                if(thirdNum<0)
                {
                    positive = !positive;
                }
                Console.WriteLine("The product of the numbers is {0}!", positive?"positive":"negative");
            }
    }
}
