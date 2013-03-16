using System;

class Student : Human, ICommentable
{
    public int StudentID { get; private set; }
    public string Comment { get; set; }

    public Student(string firstName, string lastName)
        : base(firstName, lastName)
    {

    }
}
