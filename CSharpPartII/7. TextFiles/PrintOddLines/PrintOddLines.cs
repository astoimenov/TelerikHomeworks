using System;
using System.IO;

namespace PrintOddLines
{
    class PrintOddLines
    {
        static void Main()
        {
            int n = 1;

            using (StreamReader input = new StreamReader("../../PrintOddLines.cs"))
                for (string line; (line = input.ReadLine()) != null; n++)
                    if (n % 2 == 1) Console.WriteLine(line);
        }
    }
}
