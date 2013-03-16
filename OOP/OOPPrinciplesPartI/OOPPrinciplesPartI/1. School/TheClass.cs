using System;
using System.Collections.Generic;
using System.Text;

class TheClass : ICommentable, IComparable<TheClass>
{
    private readonly SortedSet<Student> students = new SortedSet<Student>();
    private readonly SortedSet<Teacher> teachers = new SortedSet<Teacher>();

    public string ClassID { get; private set; }
    public string Comment { get; set; }

    public TheClass(string classID)
    {
        this.ClassID = classID;
    }
    public TheClass AddStudent(params Student[] students)
    {
        foreach (Student student in students)
        {
            this.students.Add(student);
        }
        return this;
    }
    public TheClass RemoveStudent(Student student)
    {
        this.students.Remove(student);
        return this;
    }

    public TheClass AddTeacher(params Teacher[] teachers)
    {
        foreach (Teacher teacher in teachers)
        {
            this.teachers.Add(teacher);
        }
        return this;
    }
    public TheClass RemoveTeacher(Teacher teacher)
    {
        this.teachers.Remove(teacher);
        return this;
    }

    public int CompareTo(TheClass other)
    {
        return this.ClassID.CompareTo(other.ClassID);
    }

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();

        text.Append("Class text ID: ");
        text.AppendLine(this.ClassID);
        text.AppendLine("Teachers:");
        text.AppendLine(this.teachers.ToString<Teacher>());
        text.AppendLine("Students:");
        text.AppendLine(this.students.ToString<Student>());
        return text.ToString();
    }
}
