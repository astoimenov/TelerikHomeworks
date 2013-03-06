using System;

namespace StringArraySortMethod
{
    class StringArraySortMethod
    {
        static void Main()
        {
            Console.WriteLine("Enter the elements of the string arrays separated by comma :");
            string[] stringArray = Console.ReadLine().Split(',');
            Console.WriteLine();
            SortStringArray(ref stringArray);
            Console.WriteLine("The sorted string is:");
            for (int i = 0; i < stringArray.Length - 1; i++)
            {
                Console.Write("{0},", stringArray[i]);
            }
            Console.WriteLine("{0}", stringArray[stringArray.Length - 1]);
        }

        private static void SortStringArray(ref string[] stringArray)
        {
            int[] lengthArray = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                lengthArray[i] = stringArray[i].Length;
            }
            Array.Sort(lengthArray, stringArray);
            return;
        }
    }
}
