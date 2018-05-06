using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch("Basic");
            Console.WriteLine("Please start up stopclock \"Basic\" The Action commands: start || stop || times || done");
            var input = Console.ReadLine();

            while (input != "done")
            {
                switch (input) {
                    case "start":
                        timer.Start();
                        break;
                    case "stop":
                        timer.Stop();
                        break;
                    case "times":
                        timer.GetTimeSpans();
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
