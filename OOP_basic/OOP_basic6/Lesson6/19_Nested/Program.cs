﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Nested
{
    public static class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Static ctor MyClass");
            Nested nested = new Nested();
            nested.MethodFromNested();
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static method");
        }

        public class Nested
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Nested method");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested nested = new MyClass.Nested();
            MyClass.StaticMethod();
        }
    }
}
