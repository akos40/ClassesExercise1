using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("Should I start a stopwatch?(y/n)");
                var str = Console.ReadLine();
                if (str.Equals("n"))
                {
                    break;
                }
                else if (str.Equals("y"))
                {
                    Console.WriteLine("Starting watch!");
                    var start = stopwatch.Start();
                    Console.ReadLine();
                    Console.WriteLine("Stopping watch!");
                    var stop = stopwatch.Stop();

                    var duration = stop - start;
                    Console.WriteLine("Stopwatch duration: " + duration);
                    Console.WriteLine();
                }
            }
        }
    }
}
