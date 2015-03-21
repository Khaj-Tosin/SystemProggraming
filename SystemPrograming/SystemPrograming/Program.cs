using System;
using System.Timers;

class ReadKeys
{
    static DateTime d1;

    static void Main()
    {
        Timer tmr = new System.Timers.Timer();
        tmr.Elapsed += new ElapsedEventHandler(StartGame);
        tmr.Interval = 2000;
        tmr.Enabled = true;

        // DateTime d1 = DateTime.Now;

        Console.ReadKey();

        DateTime d2 = DateTime.Now;

        Console.WriteLine("Time that you needed is ");
        Console.WriteLine(d2 - d1);
        Console.WriteLine("\n\n\n");
    }

    public static void StartGame(object source, ElapsedEventArgs e)
    {
        Console.WriteLine("PRESS !");
        d1 = DateTime.Now;
    }
}