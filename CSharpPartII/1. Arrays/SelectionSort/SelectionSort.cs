using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int temp;

            Console.Write("Enter number of elements: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayLength; i++)
            {
                int min = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            Console.WriteLine();
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
