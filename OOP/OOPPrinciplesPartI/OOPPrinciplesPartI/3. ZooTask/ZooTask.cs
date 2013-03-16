using System;

class ZooTask
{
    static void Main()
    {
        Dog myDog = new Dog(11, "Rex", Sex.Male);
        Frog myFrog = new Frog(9, "Boko", Sex.Male);
        Tomcat myTomcat = new Tomcat(4, "Tommy");
        Kitten myKitten = new Kitten(3, "Kotence");

        Animal[] animals = new Animal[4];

        animals[0] = myDog;
        animals[1] = myFrog;
        animals[2] = myTomcat;
        animals[3] = myKitten;

        Console.WriteLine(myFrog);
        myFrog.ProduceSound();
        Console.WriteLine();
        Console.WriteLine(myDog);
        myDog.ProduceSound();
        Console.WriteLine();
        Console.WriteLine(myKitten);
        myKitten.ProduceSound();
        Console.WriteLine();
        Console.WriteLine(myTomcat);
        myTomcat.ProduceSound();
        Console.WriteLine();

        double averageAge = Animal.AverageAge(animals);
        Console.WriteLine("Avarage age of the animals in the zoo: " + averageAge + "yrs");
    }
}