using System;

class CompareFloatingPointVariables
{
    static void Main()
    {
        float f1 = 5.3f;
        float f2 = 6.01f;
        bool isEqualF1toF2 = (f1 == f2);

        float f3 = 5.00000001f;
        float f4 = 5.00000003f;

        bool isEqualF3toF4 = (f3 == f4);

        Console.WriteLine("Are number 5.3 and 6.01 equal? Answer: " + isEqualF1toF2);
        Console.WriteLine("Are number 5.00000001 and 5.00000003 equal? Answer: " + isEqualF3toF4);

    }
}
