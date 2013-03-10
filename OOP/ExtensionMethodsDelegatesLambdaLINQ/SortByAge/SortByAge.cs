/*4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/

using System;
using System.Linq;

class SortByAge
{
    static void Main()
    {
        Student[] myClass = new Student[3];

        Student firstStudent = new Student();
        firstStudent.firstName = "Alexander";
        firstStudent.lastName = "Kadiev";
        firstStudent.age = 19;
        myClass[0] = firstStudent;

        Student secondStudent = new Student();
        secondStudent.firstName = "Stanislava";
        secondStudent.lastName = "Yaneva";
        secondStudent.age = 21;
        myClass[1] = secondStudent;

        Student thirdStudent = new Student();
        thirdStudent.firstName = "Ivaylo";
        thirdStudent.lastName = "Cvetkov";
        thirdStudent.age = 32;
        myClass[2] = thirdStudent;

        var sortedClass =
            from student in myClass
            where student.age >= 18 && student.age <= 24
            select student;

        foreach (var student in sortedClass)
        {
            Console.WriteLine("{0} {1} {2}", student.firstName, student.lastName, student.age);
        }
    }
}
