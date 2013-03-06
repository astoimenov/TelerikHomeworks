using System;

class CheckStateOfABit
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;
        bool bitCheck = bit == 1;
        if (bitCheck)
        {
            Console.WriteLine(bitCheck);
        }
        else
        {
            Console.WriteLine(bitCheck);
        }
    }
}
