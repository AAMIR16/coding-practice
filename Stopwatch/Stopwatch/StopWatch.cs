using System;
using System.Threading;
using System.IO;

namespace Stopwatch
{
    class StopWatch
    {
        static DateTime startime;
        static DateTime endtime;
        DateTime start;
        

        public static void Start()
        {
            startime = DateTime.Now;
        }

        public static void Stop()
        {
            endtime = DateTime.Now;
            var Timespan = (endtime - startime) ;
            Console.WriteLine("time taken = {0}", Timespan);
            
        }

        public static void Implementation()
        {
            Console.WriteLine("Enter Start/Stop for stopwatch");
            string input1 = Console.ReadLine();

            if (input1.ToLower() == "start")
            {
                StopWatch.Start();
            }
            //else if (input.ToLower() == "stop")
            //{
            //    StopWatch.Stop();
            //}
            Console.WriteLine("Enter stop to stop");
            string input2 = Console.ReadLine();

            if (input2.ToLower() == "stop")
            {
                StopWatch.Stop();
            }

        }
        //public static DateTime Duration()
        //{
        //    return;
        //}

    }
}
