using System;
using System.Linq;

namespace ConvertDecimalToBinary
{
    class DecToBin
    {
        static void Main()
        {
            Console.Write("n = ");
            int number = int.Parse(Console.ReadLine());
            int numSys = 2;
            int remainder;
            int result;
            string numBin = "";

            remainder = number % numSys;
            result = number / numSys;
            numBin += remainder;

            while (result > 0)
            {
                remainder = result % numSys;
                result /= numSys;
                numBin += remainder;
            }

            numBin = new string(numBin.ToCharArray().Reverse().ToArray());
            Console.WriteLine("The Binary representation of given number\n n = {0} is: {1}", number, numBin);
        }
    }
}
