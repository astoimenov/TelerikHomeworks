using System;

namespace SolveTasks
{
    class SolveTasks
    {
        static void Main()
        {
            string menuChoice =
             @" MENU
 
 1) Reverse number
 2) Calculate average of a sequence
 3) Solves a linear equation a * x + b = 0
           
 Input your choice: ";
            Console.Write(menuChoice);
            string choiceStr = "";
            int choice = CheckForEmpty(choiceStr);


            if (choice < 1 | choice > 3)
            {
                Console.WriteLine("!!! wrong imput try again..");
                choice = byte.Parse(Console.ReadLine());
            }
            else if (choice == 1) ReverseDigits();
            else if (choice == 2) Average();
            else if (choice == 3) Equation();
        }



        static int CheckForEmpty(string input)
        {
            string choiceStr = Console.ReadLine();

            if (choiceStr == string.Empty)
            {
                while (true)
                {
                    Console.WriteLine("empty string not allowed imput again");
                    choiceStr = Console.ReadLine();
                    if (choiceStr != string.Empty) break;
                }
            }
            int value = int.Parse(choiceStr);
            return value;
        }



        static void ReverseDigits()
        {
            Console.WriteLine("input number to reverse");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("your number is: {0}", number);
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + (number % 10);
                number /= 10;
            }
            Console.WriteLine("reversed => {0}", reversed);
            PlayAgain();
        }



        static void Average()
        {
            Console.WriteLine("You have chosen \"seqence of integers\"");
            Console.WriteLine("how long will be the sequence of integers");
            string choiceStr = "";
            int choice = CheckForEmpty(choiceStr);

            int[] arr = new int[choice];
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter value for index[{0}]", i);
                string input = "";
                int value = CheckForEmpty(input);
                arr[i] = value;
                sum += arr[i];
            }
            Console.WriteLine("The average sum is {0}", sum / arr.Length);
            PlayAgain();
        }

        static void Equation()
        {
            Console.WriteLine("You have chosen \"Solves a linear equation a * x + b = ?\"");
            Console.WriteLine("input a: ");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                while (true)
                {
                    Console.WriteLine("a must be > 0 try again");
                    a = int.Parse(Console.ReadLine());
                    if (a != 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("input b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("input x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("the result of the equation a * x + b = ? is : {0}", (a * x) + b);
            PlayAgain();

        }

        static void PlayAgain()
        {
            Console.WriteLine(@"wanna do it again?
    type: yes or no");
            string choice = Console.ReadLine();
            if (choice != "yes" | choice != "no" | choice == string.Empty)
            {
                while (true)
                {
                    Console.WriteLine("choice must be yes or no");
                    if (choice == "yes" | choice == "no")
                    {
                        if (choice == "yes")
                        {
                            Console.Clear();
                            Main(); break;
                        }
                        if (choice == "no")
                        {
                            Console.Clear();
                            Console.WriteLine("Bye Bye!"); break;
                        }
                    }
                }
            }

        }
    }
}
