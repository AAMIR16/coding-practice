using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool decision = true;
            while (decision)
            {
                StopWatch.Implementation();
                Console.WriteLine("would you like to rerun? Type \'Y\' or \'N\'");

                string ans = Console.ReadLine();
                if (ans.ToLower() == "y")
                {
                    StopWatch.Implementation();
                }
                else
                    decision = false;
            }
        }
    }
}
