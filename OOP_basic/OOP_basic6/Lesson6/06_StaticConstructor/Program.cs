using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StaticConstructor
{

    class NotStaticClass
    {
        private static int field;

        public static int Propety
        {
            get { return field; }
            set { field = value; }
        }

        static NotStaticClass()
        {
            Console.WriteLine("Static constructor");
            NotStaticClass.field = 1;
        }

        public NotStaticClass()
        {
            Console.WriteLine("Constuctor");
            field = 2;
        }

        public static void Method()
        {
            Console.WriteLine("Empty");
        }
        public static void Method(string str)
        {
            Console.WriteLine(str);
        }
        

        public void NotStaticMethod()
        {
            
            Console.WriteLine(NotStaticClass.field);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass notStaticClass = new NotStaticClass();
            notStaticClass.NotStaticMethod();

            Console.WriteLine(NotStaticClass.Propety);
            NotStaticClass.Propety = 3;
            notStaticClass.NotStaticMethod();

            NotStaticClass.Method();
            NotStaticClass.Method("123123");
            
        }
    }
}
