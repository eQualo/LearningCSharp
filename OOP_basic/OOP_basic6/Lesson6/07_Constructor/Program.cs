using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Constructor
{
    class NotStaticClass
    {
        static NotStaticClass()
        {
            Console.WriteLine("static ctor");

        }

        public NotStaticClass()
        {
            Console.WriteLine("ctor");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("SM");
        }

        public void Method()
        {
            Console.WriteLine("NSM");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //NotStaticClass.StaticMethod(); //only static ctor

            new NotStaticClass().Method(); //both ctors
            new NotStaticClass();

            NotStaticClass.StaticMethod();
        }
    }
}
