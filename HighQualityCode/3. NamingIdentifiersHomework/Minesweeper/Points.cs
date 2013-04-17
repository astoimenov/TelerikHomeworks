namespace Minesweeper
{
    using System;

    public class Points
    {
        private string name;
        private int points;       

        public Points(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public Points()
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                this.points = value;
            }
        }
    }
}
