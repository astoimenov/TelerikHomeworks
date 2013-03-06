using System;

class ExtractBitState
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit number: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;
        Console.WriteLine("Value = {0}", bit);
    }
}
