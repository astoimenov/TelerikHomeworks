using System;

namespace CompareTwoCharArrays
{
    class CompareTwoCharArrays
    {
        static void Main()
        {
            Console.Write("Enter number of the first aray: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number of the second aray: ");
            int b = int.Parse(Console.ReadLine());
            bool equal = true;

            if (a == b)
            {
                Console.WriteLine("Enter the elements of the first array:");
                char[] firstArray = new char[a];
                for (int i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the elements of the first array:");
                char[] secondArray = new char[b];
                for (int i = 0; i < secondArray.Length; i++)
                {
                    secondArray[i] = char.Parse(Console.ReadLine());
                }
                for (int i = 0; i < a; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        equal = false;
                    }
                }
            }
            else
            {
                equal = false;
            }
            Console.WriteLine("Are the arrays equal? {0}", equal);
        }
    }
}
