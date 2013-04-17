using System;

public class Statistics
{
    public static void Main()
    {
    }

    public void PrintStatistics(double[] arr)
    {
        this.PrintMax(arr);
        this.PrintMin(arr);
        this.PrintAvg(arr);
    }

    private void PrintAvg(double[] arr)
    {
        double sumOfTheElements = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sumOfTheElements += arr[i];
        }

        double average = sumOfTheElements / arr.Length;
        Console.WriteLine("The average of all elements is: " + average);
    }

    private void PrintMin(double[] arr)
    {
        double min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine("The minimal element is: " + min);
    }

    private void PrintMax(double[] arr)
    {
        double max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("The maximal element is: " + max);
    }
}