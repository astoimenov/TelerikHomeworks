using System;

class Tomcat : Cat, ISoundable
{
    public Tomcat(int age, string name)
    {
        this.Age = age;
        this.Name = name;
        this.Sex = Sex.Male;
    }

    public override void ProduceSound()
    {
        Console.WriteLine("I am Tomcat!");
    }
}