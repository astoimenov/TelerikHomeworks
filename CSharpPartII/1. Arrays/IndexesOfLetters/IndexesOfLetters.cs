using System;

namespace IndexesOfLetters
{
    class IndexesOfLetters
    {
        static void Main()
        {
            char[] arr = new char[26];
            string word = (Console.ReadLine().ToLower());

            for (int i = 0; i < 26; i++)
            {
                arr[i] = Convert.ToChar('a' + i);
            }

            for (int j = 0; j < word.Length; j++)
            {
                Console.WriteLine("{0} [{1}]", word[j], word[j] - 'a');
            }                        
        }
    }
}
