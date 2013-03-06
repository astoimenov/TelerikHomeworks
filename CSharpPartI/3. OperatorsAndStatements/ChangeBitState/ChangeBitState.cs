using System;

class ChangeBitState
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit value: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        if (bit == 1)
        {
            int secondMask = ~(1 << p);
            int firstResult = n & secondMask;
            Console.WriteLine(firstResult);
        }
        else
        {
            int thirdMask = 1 << p;
            int secondResult = n | thirdMask;
            Console.WriteLine(secondResult);
        }
    }
}
