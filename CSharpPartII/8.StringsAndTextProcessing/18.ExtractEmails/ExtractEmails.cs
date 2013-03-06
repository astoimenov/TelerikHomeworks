﻿using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string str = "Static void Main() jasssonpet@gmail.com. using System,jason@abv.bg return";

        foreach (var item in Regex.Matches(str, @"\w+@\w+\.\w+"))
            Console.WriteLine(item);
    }
}
