using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ExtractText
{
    class ExtractText
    {
        static void Main(string[] args)
        {
            string firstFileName = "../../input.txt";

            ReadFile(firstFileName);
        }

        private static void ReadFile(string firstFileName)
        {
            using (StreamReader sourceFile = new StreamReader(firstFileName))
            {
                string line = sourceFile.ReadLine();
                while (line != null)
                {
                    string pattern = ">[^<]*</";
                    string edited;
                    int length;
                    foreach (Match match in Regex.Matches(line, pattern))
                    {
                        edited = match.Value.ToString();
                        length = edited.Length;
                        edited = edited.Remove(length - 2, 2);
                        edited = edited.Remove(0, 1);
                        if (edited != null)
                        {
                            Console.WriteLine(edited);
                        }

                    }

                    line = sourceFile.ReadLine();
                }
            }
        }
    }
}
