using System;

class DivedibleBy5And7
{
    static void Main()
    {
        Console.WriteLine("vavedete stoinost za number: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);
        bool divide = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine(divide);
    }
}
