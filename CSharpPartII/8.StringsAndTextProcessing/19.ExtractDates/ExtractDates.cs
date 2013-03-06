﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string str = "Static void Main() 12.10.2012, 50.13.2012";

        DateTime date;
        foreach (Match item in Regex.Matches(str, @"\b[0-9]{2}.[0-9]{2}.[0-9]{4}\b"))
            if (DateTime.TryParse(item.Value, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
    }
}
