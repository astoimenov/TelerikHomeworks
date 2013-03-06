using System;

class IsNumberAPrime
{
    static void Main()
    {
        Console.WriteLine("Enter a number [1, 100]: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0 && num <= 100)
        {
            int divider = 2;
            double MaxDivider = Math.Sqrt(num);
            do
            {
                int check = num % divider;
                divider++;
                if (check == 0)
                {
                    Console.WriteLine("MinDivider = {0}", divider);
                }
                else
                {
                    Console.WriteLine("The number is prime!");
                }
            } while (divider < MaxDivider);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }

    }
}
