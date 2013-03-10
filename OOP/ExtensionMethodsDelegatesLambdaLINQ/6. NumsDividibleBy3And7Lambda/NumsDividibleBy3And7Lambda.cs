/*Write a program that prints from given array
 * of integers all numbers that are divisible by 7 and 3.
 * Use the built-in extension methods and lambda expressions. */

using System;
using System.Linq;

class NumsDividibleBy3And7Lambda
{
    static void Main()
    {
        int[] numbers = new int[100];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }

        var dividibleNums = numbers.Where(x => x % 21 == 0);
        foreach (var number in dividibleNums)
        {
            Console.WriteLine(number);
        }
    }
}
