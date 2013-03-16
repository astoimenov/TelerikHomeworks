using System;
using System.Text;

class Discipline : ICommentable, IComparable<Discipline>
{
    public int LecturesCount { get; private set; }
    public int ExercisesCount { get; private set; }
    public string Name { get; private set; }
    public string Comment { get; set; }

    public Discipline(string name, int lecturesCount = 0, int exercisesCount = 0)
    {
        this.Name = name;
        this.LecturesCount = lecturesCount;
        this.ExercisesCount = exercisesCount;
    }

    public int CompareTo(Discipline other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.Append("Discipline: ");
        text.AppendLine(this.Name);
        text.Append("Number of lectures: ");
        text.AppendLine(this.LecturesCount.ToString());
        text.Append("Number of exercises: ");
        text.AppendLine(this.ExercisesCount.ToString());
        return text.ToString();
    }
}
