using System;

namespace HelloName
{
    class HelloName
    {
        static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            Console.Write("Name: ");
            Hello(Console.ReadLine());
        }
    }
}
