/*1. Define a class Student, which contains data about a student - 
 *   first, middle and last name, SSN, permanent address, mobile phone,
 *   e-mail, course, specialty, university, faculty. Use an enumeration
 *   for the specialties, universities and faculties. Override the standard methods, 
 *   inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 *2. Add implementations of the ICloneable interface.
 *   The Clone() method should deeply copy all object's fields into a new object of type Student.
 *3. Implement the  IComparable<Student> interface to compare students by names
 *   (as first criteria, in lexicographic order) and by social security number 
 *   (as second criteria, in increasing order).*/

using System;

class StudentSystem
{
    static void Main()
    {
        Student askata = new Student("Asen", "Nikolov", "Sirakov", 101212009, "Sofia, bul. Bulgaria 1000", 0884345592,
            "askata@mail.bg", 2, Universities.SofiaUniversity, Faculties.ElectronicalFaculty, Specialties.Telecommunication);
        Console.WriteLine(askata);
        Console.WriteLine();
        Student pesho = askata.Clone();
        Console.WriteLine(pesho);
        pesho.FirstName = "Pesho";
        Console.WriteLine(pesho.FirstName);
        Console.WriteLine(askata.FirstName);
        Console.WriteLine();

        Console.WriteLine(askata.CompareTo(pesho));
        pesho.FirstName = "Peter";
        Console.WriteLine(askata.CompareTo(pesho));
    }
}