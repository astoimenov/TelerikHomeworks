using System;

class UIntBitExchange
{
     static void Main()
    {
        Console.Write("Enter number: ");
        uint numberN = uint.Parse(Console.ReadLine());
        for (int numberCount = 3; numberCount <= 5; numberCount++)
        {
            uint numberBit0 = ((uint)1 << numberCount);
            uint numberBit1 = ((uint)1 << (numberCount + 21));
            numberBit1 = (numberN & numberBit1);
            numberBit0 = (numberN & numberBit0);
            if (numberBit1 != 0)
            {
                numberBit1 = ((uint)1 << numberCount);
            }
            uint numberExchange;
            if (numberBit0 != numberBit1)
            {
                if (numberBit0 > numberBit1)
                {
                    numberExchange = ((uint)1 << (21 + numberCount));
                    numberN = numberN | numberExchange;
                    numberExchange = ~((uint)1 << (numberCount));
                    numberN = numberN & numberExchange;
                }
                else if (numberBit0 < numberBit1)
                {
                    numberExchange = ((uint)1 << (numberCount));
                    numberN = numberN | numberExchange;
                    numberExchange = ~((uint)1 << (21 + numberCount));
                    numberN = numberN & numberExchange;
                }
            }
        }
        Console.WriteLine("The number after exchange is: {0}", numberN);
    }
}
