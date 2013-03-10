/*Write a program that prints from given array of integers
 * all numbers that are divisible by 7 and 3 with LINQ. */

using System;
using System.Linq;

class NumsDividibleBy3And7LINQ
{
    static void Main()
    {
        int[] numbers = new int[100];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }

        var dividibleNums =
                           from number in numbers
                           where number % 21 == 0
                           select number;
        foreach (var number in dividibleNums)
        {
            Console.WriteLine(number);
        }
    }
}
