//Ivan Lazcano Sindin
using System;
using System.Threading;

class ClockEverySecond
{
    public static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine(DateTime.Now.Hour.ToString("00")+":"
                +DateTime.Now.Minute.ToString("00")+":"
                +DateTime.Now.Second.ToString("00"));
            Thread.Sleep(1000);
        }
    }
}
