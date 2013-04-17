using System;

public class IfStatementsRefactoring
{
    public static void Main()
    {
        Potato potato;
        // ... 
        if (potato != null)
        {
            if (potato.HasBeenPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }
        }

        bool xInRange = x >= MIN_X && x <= MAX_X;
        bool yInRange = MAX_Y >= y && MIN_Y <= y;
        if (xInRange && yInRange && shouldVisitedCell)
        {
            VisitCell();
        }
    }
}