using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StaticClass
{
    static class StaticClass : Object
    {
        static StaticClass()
        {
            Console.WriteLine("static ctor");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static method");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.StaticMethod();
        }
    }
}
