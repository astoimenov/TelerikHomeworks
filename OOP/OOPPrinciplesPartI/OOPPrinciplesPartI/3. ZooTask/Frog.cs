using System;

class Frog : Animal, ISoundable
{
    public Frog(int age, string name, Sex sex)
    {
        this.Age = age;
        this.Name = name;
        this.Sex = sex;
    }

    public override void ProduceSound()
    {
        Console.WriteLine("I am Frog!");
    }
}