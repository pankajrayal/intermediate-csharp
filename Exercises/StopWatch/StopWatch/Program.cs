using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopWatch.Start();
                Thread.Sleep(1000);

                stopWatch.Stop();

                Console.WriteLine("Duration: " + stopWatch.GetInterval());
                Console.WriteLine("Press ENTER to run the stopwatch one more time.");
                Console.ReadLine();
            }
        }
    }
}
