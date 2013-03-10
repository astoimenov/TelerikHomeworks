using System;
using System.Threading;

class Timer
{
    public delegate void MethodToExecute();
    public MethodToExecute method;

    public void Start(int interval, int totalTime)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(totalTime);
        while (start <= end)
        {

            method();
            Thread.Sleep(interval * 1000);
            start = DateTime.Now;
        }
    }
}