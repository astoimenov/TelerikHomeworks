using System;

class CheckBrackets
{
    static bool CheckBrack(string str)
    {
        int stack = 0;

        for (int i = 0; i < str.Length && stack >= 0; i++)
        {
            if (str[i] == '(') stack++;
            if (str[i] == ')') stack--;
        }

        return stack == 0;
    }

    static void Main()
    {
        Console.WriteLine(CheckBrack("((a + b) / 5 - d)"));
        Console.WriteLine(CheckBrack(")(a+b))"));
    }
}
