using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SelfAssociation
{
    class MyClass
    {
        MyClass instance;
        public MyClass()
        {
            Console.WriteLine("Constructor");
            instance = new MyClass();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            Console.ReadKey();
        }
    }
}
