﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# World!");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            
            Console.ReadLine();
        }
    }
}
