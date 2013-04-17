using System;

public class LoopRefactoring
{
    public static void Main()
    {
        for (int index = 0; index < 100; index++)
        {
            if (index % 10 == 0)
            {
                if (array[index] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                }
            }

            Console.WriteLine(array[index]);
        }
    }
}
