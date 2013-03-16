using System;
using System.Text;
using System.Collections.Generic;

class Teacher : Human, ICommentable
{
    private readonly SortedSet<Discipline> disciplines = new SortedSet<Discipline>();
    public string Comment { get; set; }

    public Teacher(string firstName, string lastName)
        : base(firstName, lastName)
    {

    }

    public Teacher AddDiscipline(params Discipline[] disciplines)
    {
        foreach (Discipline discipline in disciplines)
        {
            this.disciplines.Add(discipline);
        }
        return this;
    }
    public Teacher RemoveDiscipline(Discipline discipline)
    {
        this.disciplines.Remove(discipline);
        return this;
    }

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine();
        text.AppendLine(base.ToString());
        text.AppendLine();
        text.AppendLine(this.disciplines.ToString<Discipline>());
        return text.ToString();
    }
}
