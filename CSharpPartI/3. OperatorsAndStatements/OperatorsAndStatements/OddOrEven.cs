using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Vavedete stoinost za number: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);
        if (number%2==0)
        {
            Console.WriteLine("The number is even!");
        }
        else
            Console.WriteLine("The number is odd!");
    }
}
