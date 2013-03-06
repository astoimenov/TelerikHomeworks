using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyRight = '©';

        Console.OutputEncoding=Encoding.UTF8; 

        Console.WriteLine(@"

    {0}

   {0} {0}

  {0}   {0}

 {0} {0} {0} {0}", copyRight);    
    } 
}

