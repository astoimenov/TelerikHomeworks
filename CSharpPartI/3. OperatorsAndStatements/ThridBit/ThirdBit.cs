using System;

class ThirdBit
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int mask = 8;
        int addMask = input & mask;
        int final = addMask >> 3;
        bool result = (final == 1);
        if (result)
        {
            Console.WriteLine("The thrid bit of the number is 1!");
        }
        else
        {
            Console.WriteLine("The thrid bit of the number is 0!");
        }
    }
}
