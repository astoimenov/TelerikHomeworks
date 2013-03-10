/*Using delegates write a class Timer that has can execute certain method at each t seconds.*/

using System;

class TimerDelegate
{
    public static void DateAndTime()
    {
        Console.WriteLine(DateTime.Now);
    }

    static void Main()
    {
        Timer timer = new Timer();
        timer.method = DateAndTime;
        timer.Start(1, 10);
    }
}
