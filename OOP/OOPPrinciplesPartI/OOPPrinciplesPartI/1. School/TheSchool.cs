/* We are given a school. In the school there are classes of students.
 * Each class has a set of teachers. Each teacher teaches a set of disciplines.
 * Students have name and unique class number. Classes have unique text identifier.
 * Teachers have name. Disciplines have name, number of lectures and number of exercises.
 * Both teachers and students are people. Students, classes, teachers and disciplines
 * could have optional comments (free text block).
 * Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
 * encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.*/

using System;

class TheSchool
{
    static void Main()
    {
        Console.WriteLine(new School("Telerik")
            {
                new TheClass("OOP").AddStudent(
                    new Student("Smith", "Bill"),
                    new Student("Alexander", "Kadiev"),
                    new Student("Elica", "Lazarova"),
                    new Student("Antonio", "Ivanov"),
                    new Student("Denis", "Petrov"),
                    new Student("Stefan", "Iordanov")
                ).RemoveStudent(
                    new Student("Smith", "Bill")
                ).AddTeacher(
                    new Teacher("Bart", "Simpson").AddDiscipline(
                        new Discipline("HTML", 3, 3),
                        new Discipline("CSS", 1, 2),
                        new Discipline("C#", 1, 1)
                    ).RemoveDiscipline(
                        new Discipline("CSS")
                    )
                ),

                new TheClass("C# 2").AddStudent(
                    new Student("Alex", "Brown"),
                    new Student("Peter", "Griffin"),
                    new Student("Cleveland", "Brown")
                ).AddTeacher(
                    new Teacher("Stewie", "Griffin").AddDiscipline(
                        new Discipline("HTML", 3, 3)
                    ),
                    new Teacher("Homer", "Simpson").AddDiscipline(
                        new Discipline("C#", 3, 3)
                    )
                )
            }
        );
    }
}