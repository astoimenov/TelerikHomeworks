using System;

public class CookingProgram
{
    public static void Main()
    {
    }

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Peel(potato);
            this.Cut(potato);
            Bowl bowl = this.GetBowl();
            bowl.Add(potato);
            Carrot carrot = this.GetCarrot();
            Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            // ... 
        }

        private Carrot GetCarrot()
        {
            // ...
        }

        private Potato GetPotato()
        {
            // ...
        }

        private void Cut(Vegetable potato)
        {
            // ...
        }
    }
}