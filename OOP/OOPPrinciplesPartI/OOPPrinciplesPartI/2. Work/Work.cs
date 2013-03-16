/*Define abstract class Human with first name and last name.
 * Define new class Student which is derived from Human and 
 * has new field – grade. Define class Worker derived from Human with 
 * new property WeekSalary and WorkHoursPerDay and method MoneyPerHour()
 * that returns money earned by hour by the worker. Define the proper 
 * constructors and properties for this hierarchy. Initialize a list of 10
 * students and sort them by grade in ascending order (use LINQ or OrderBy() 
 * extension method). Initialize a list of 10 workers and sort them by money per hour 
 * in descending order. Merge the lists and sort them by first name and last name.*/

using System;
using System.Linq;
using System.Collections.Generic;

class Work
{
    static void Main()
    {
        List<Student> studentsList = new List<Student>(10) 
            {
                new Student(5, "Denis", "Petrov"),
                new Student(4, "Ivan", "Milchev"),
                new Student(3, "Stanislava", "Yaneva"),
                new Student(4, "Hristian", "Shtirkov"),
                new Student(5, "Elica", "Lazarova"),
                new Student(6, "Ivo", "Boichev"),
                new Student(3, "Antonio", "Filipov"),
                new Student(4, "Konstantin", "Krystev"),
                new Student(5, "Georgi", "Dragnev"),
                new Student(3, "Stefan", "Iordanov"),
            };

        Worker worker1 = new Worker(3500, 40, "Dimityr", "Vrachkov");
        Worker worker2 = new Worker(1250, 35, "Blagovest", "Metodiev");
        Worker worker3 = new Worker(2151, 40, "Ivan", "Matev");
        Worker worker4 = new Worker(7358, 38, "Biliana", "Metodieva");
        Worker worker5 = new Worker(520, 12, "Sonia", "Getova");
        Worker worker6 = new Worker(385, 10, "Teodora", "Jeliazkova");
        Worker worker7 = new Worker(1100, 20, "Mihaela", "Metodieva");
        Worker worker8 = new Worker(2810, 37, "Radoslav", "Vitanov");
        Worker worker9 = new Worker(2800, 36, "Plamen", "Marinov");
        Worker worker10 = new Worker(5355, 40, "Simeon", "Nikolov");

        worker1.SalaryPerHour = worker1.MoneyPerHour();
        worker2.SalaryPerHour = worker2.MoneyPerHour();
        worker3.SalaryPerHour = worker3.MoneyPerHour();
        worker4.SalaryPerHour = worker4.MoneyPerHour();
        worker5.SalaryPerHour = worker5.MoneyPerHour();
        worker6.SalaryPerHour = worker6.MoneyPerHour();
        worker7.SalaryPerHour = worker7.MoneyPerHour();
        worker8.SalaryPerHour = worker8.MoneyPerHour();
        worker9.SalaryPerHour = worker9.MoneyPerHour();
        worker10.SalaryPerHour = worker10.MoneyPerHour();

        List<Worker> workersList = new List<Worker>(10) 
            {
                worker1, worker2, worker3, worker4, worker5, worker6, worker7, worker8, worker9, worker10
            };

        var orderStudents = from student in studentsList
                            orderby student.Grade ascending
                            select student;

        Console.WriteLine("Students sorted by grades:");
        Console.WriteLine();
        foreach (var orderStudent in orderStudents)
        {
            Console.WriteLine(orderStudent);
        }

        var orderWorkers = from worker in workersList
                           orderby worker.SalaryPerHour descending
                           select worker;

        Console.WriteLine();
        Console.WriteLine("Workers sorted by moneyPerHour:");
        Console.WriteLine();
        foreach (var orderWorker in orderWorkers)
        {
            Console.WriteLine(orderWorker);
        }

        List<Human> humanList = new List<Human>(20);
        humanList.AddRange(studentsList);
        humanList.AddRange(workersList);

        var sortHuman = from person in humanList
                        orderby person.FirstName ascending, person.LastName ascending
                        select person;

        Console.WriteLine();
        Console.WriteLine("Humans sorted by names:");
        Console.WriteLine();
        foreach (var person in sortHuman)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);
        }
    }
}