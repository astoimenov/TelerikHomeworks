/*1. Implement an extension method Substring(int index, int length) for the class StringBuilder
 *   that returns new StringBuilder and has the same functionality as Substring in the class String.*/

using System;
using System.Text;

class SubString
{
    static void Main()
    {
        StringBuilder testing = new StringBuilder();
        testing.AppendLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
        Console.WriteLine(testing.SubString(5, 5).ToString());
    }
}