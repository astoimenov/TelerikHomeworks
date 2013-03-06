using System;
using System.IO;

namespace TwoFilesIntoAnother
{
    class TwoFilesIntoAnother
    {
        static void WriteToFile(StreamWriter output, string file)
        {
            using (StreamReader input = new StreamReader(file))
                for (string line; (line = input.ReadLine()) != null; )
                    output.WriteLine(line);
        }

        static void Main()
        {
            string[] files = { "../../TwoFilesIntoAnother.cs", "../../TwoFilesIntoAnother.cs" };

            using (StreamWriter output = new StreamWriter("../../output.txt"))
                foreach (string file in files)
                    WriteToFile(output, file);
        }
    }
}
