using System;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxCounter = 1;
            int mostFrequent = 0;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    mostFrequent = array[i];
                }
            }

            if (maxCounter > 1)
            {
                Console.WriteLine("Most frequent number = {0}", mostFrequent);
                Console.WriteLine("Count = {0} times", maxCounter);
            }
            else
            {
                Console.WriteLine("All elements are different");
            }
        }
    }
}
