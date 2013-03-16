using System;

class Kitten : Cat, ISoundable
{
    public Kitten(int age, string name)
    {
        this.Age = age;
        this.Name = name;
        this.Sex = Sex.Female;
    }

    public override void ProduceSound()
    {
        Console.WriteLine("I am Kitten!");
    }
}