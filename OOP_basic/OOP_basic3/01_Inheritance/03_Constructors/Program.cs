﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedField);

            Console.ReadKey();
        }
    }
}
