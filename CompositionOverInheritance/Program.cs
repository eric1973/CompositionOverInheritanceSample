﻿using InternalLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOverInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SomePublicClass instance = new SomePublicClass();
            instance.CalculateDangerousAmount(2300.50M, 45231.23M);

            instance.Print();
            Console.ReadLine();
        }
    }
}
