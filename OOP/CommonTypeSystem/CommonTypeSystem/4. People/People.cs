/*4. Create a class Person with two fields – name and age.
 *   Age can be left unspecified (may contain null value.
 *   Override ToString() to display the information of a person and
 *   if age is not specified – to say so. Write a program to test this functionality.*/

using System;

class People
{
    static void Main()
    {
        Person gosho = new Person("Joro", 45);
        Person pesho = new Person("Pesho Traktorista");
        Console.WriteLine(pesho);
        Console.WriteLine();
        Console.WriteLine(gosho);
    }
}