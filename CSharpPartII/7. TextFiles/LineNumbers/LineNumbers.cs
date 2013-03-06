using System;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            int n = 1;

            using (StreamReader input = new StreamReader("../../LineNumbers.cs"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
                for (string line; (line = input.ReadLine()) != null; n++)
                    output.WriteLine("{0}.{1}", n, line);
        }
    }
}
