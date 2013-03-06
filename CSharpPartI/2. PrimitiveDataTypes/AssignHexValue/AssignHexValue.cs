using System;

class AssignHexValue
{
    static void Main()
    {
        int DecNumber = 254;
        string HexNumber = DecNumber.ToString("X");
        Console.WriteLine("The number 254 in hexademical is: " + HexNumber);
    }
}
