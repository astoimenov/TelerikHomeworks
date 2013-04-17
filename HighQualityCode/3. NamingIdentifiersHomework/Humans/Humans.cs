namespace Humans
{
    using System;

    public class Humans
    {
        public enum Sex
        {
            Male,
            Female
        }

        public void CreateHuman(int age)
        {
            Human newHuman = new Human();
            newHuman.Age = age;
            if (age % 2 == 0)
            {
                newHuman.Name = "Батката";
                newHuman.Sex = Sex.Male;
            }
            else
            {
                newHuman.Name = "Мацето";
                newHuman.Sex = Sex.Female;
            }
        }

        public class Human
        {
            public Sex Sex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
