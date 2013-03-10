using System;

public class Student
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }

    public Student(string firstName, string secondName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
    }
}
