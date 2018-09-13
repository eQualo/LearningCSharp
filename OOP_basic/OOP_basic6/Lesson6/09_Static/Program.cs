using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Static
{
    abstract class BaseClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("base static");
        }
    }

    class DerivedClass : BaseClass
    {
        public static new void StaticMethod() //замещение
        {
            Console.WriteLine("derived static");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass.StaticMethod();
            DerivedClass.StaticMethod();
        }
    }
}
