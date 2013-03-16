using System;

public class Student : Human
{
    private byte grade;

    public Student(byte grade, string firstName, string lastName)
        : base(firstName, lastName)
    {
        this.Grade = grade;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public byte Grade
    {
        get { return this.grade; }
        set
        {
            if (value > 0)
            {
                this.grade = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public override string ToString()
    {
        return string.Format("{0} {1}, Grade - {2}", this.FirstName, this.LastName, this.grade);
    }
}