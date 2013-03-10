/*Using the extension methods OrderBy() and ThenBy()
 * with LINQ sort the students by first name
 * and last name in descending order. */

using System;
using System.Linq;

class SortByNamesInDescLINQ
{
    static void Main()
    {
        Student[] students =
        {
            new Student("Alexander", "Kadiev"),
            new Student("Stanislava", "Yaneva"),
            new Student("Ivaylo", "Cvetkov")
        };

        var sorted =
                    from student in students
                    orderby student.FirstName descending, student.SecondName descending
                    select student;

        foreach (var student in sorted)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
        }
    }
}
