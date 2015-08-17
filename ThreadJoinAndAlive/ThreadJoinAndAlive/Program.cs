using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadJoinAndAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started...");

            Thread t1 = new Thread(Program.Thread1Function);
            t1.Start();

            Thread t2 = new Thread(Program.Thread2Function);
            t2.Start();

            t1.Join(); // Main thread will wait until this thread finish
            Console.WriteLine("Thread1 function completed...");

            t2.Join(); // Main thread will wait until this thread finish
            Console.WriteLine("Thread2 function completed...");

            Console.WriteLine("Main completed...");
            Console.ReadKey();
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1 function started...");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 function is about to return...");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2 function started...");
            Thread.Sleep(5000);
            Console.WriteLine("Thread2 function is about to return...");
        }
    }
}
