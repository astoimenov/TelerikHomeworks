/*Using the extension methods OrderBy() and ThenBy() 
 * with lambda expressions sort the students by first name
 * and last name in descending order. */

using System;
using System.Linq;

class SortByNamesInDescLambda
{
    static void Main()
    {
        Student[] students =
        {
            new Student("Alexander", "Kadiev"),
            new Student("Stanislava", "Yaneva"),
            new Student("Ivaylo", "Cvetkov")
        };

        var sorted = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.SecondName);

        foreach (var student in sorted)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
        }
    }
}
