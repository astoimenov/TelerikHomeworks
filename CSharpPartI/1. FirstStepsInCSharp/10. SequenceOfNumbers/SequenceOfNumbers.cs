﻿using System;

class SequenceOfNumbers
{
    static void Main()
    {
        for (int i = 2; i <= 100; i++)
            if ((i % 2) == 0)
                Console.Write(" {0} ",i);
            else
                Console.Write(" {0} ",-i);
    }
}