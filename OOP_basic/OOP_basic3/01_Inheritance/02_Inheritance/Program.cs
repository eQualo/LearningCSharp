﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);

            instance.Show();

            Console.ReadKey();
        }
    }
}
