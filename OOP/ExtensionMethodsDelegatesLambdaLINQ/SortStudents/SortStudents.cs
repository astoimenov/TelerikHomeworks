/*3. Write a method that from a given array of students finds all students
 *   whose first name is before its last name alphabetically. Use LINQ query operators.*/

using System;
using System.Linq;

class SortStudents
{
    static void Main()
    {
        Student[] myClass = new Student[3];

        Student firstStudent = new Student();
        firstStudent.firstName = "Alexander";
        firstStudent.lastName = "Kadiev";
        myClass[0] = firstStudent;

        Student secondStudent = new Student();
        secondStudent.firstName = "Stanislava";
        secondStudent.lastName = "Yaneva";
        myClass[1] = secondStudent;

        Student thirdStudent = new Student();
        thirdStudent.firstName = "Ivaylo";
        thirdStudent.lastName = "Cvetkov";
        myClass[2] = thirdStudent;

        var selectedStudents =
                              from student in myClass
                              where student.firstName.CompareTo(student.lastName) == -1
                              select student;
        foreach (var student in selectedStudents)
        {
            Console.WriteLine("{0} {1}", student.firstName, student.lastName);
        }
    }
}