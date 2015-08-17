using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace ProtectingResources
{
    class Program
    {
        static int Total = 0;

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Thread t1 = new Thread(Program.AddOneMillion);
            Thread t2 = new Thread(Program.AddOneMillion);
            Thread t3 = new Thread(Program.AddOneMillion);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            stopwatch.Stop();

            Console.WriteLine("Total = {0}", Total);
            Console.WriteLine(stopwatch.ElapsedTicks);

            Console.ReadKey();
        }

        static object _lock = new object(); // Another way to protect the Total field.
        public static void AddOneMillion()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref Total); // This is the best option
                //lock (_lock)
                //{
                //    Total++;
                //}
            }
        }
    }
}
