using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class School : IEnumerable
{
    private readonly SortedSet<TheClass> classes = new SortedSet<TheClass>();
    public string Name { get; set; }

    public School(string name)
    {
        this.Name = name;
    }

    public School AddClass(params TheClass[] classes)
    {
        foreach (TheClass klas in classes)
        {
            this.classes.Add(klas);
        }
        return this;
    }
    public School RemoveClass(TheClass klas)
    {
        this.classes.Remove(klas);
        return this;
    }

    public void Add(TheClass klas)
    {
        this.AddClass(klas);
    }
    public IEnumerator GetEnumerator()
    {
        return this.classes.GetEnumerator();
    }

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine("School: ");
        text.AppendLine(this.Name);
        text.AppendLine("-------------");
        text.AppendLine("Classes in the school: ");
        text.AppendLine("-------------");
        text.AppendLine(this.classes.ToString<TheClass>());
        return text.ToString();
    }
}