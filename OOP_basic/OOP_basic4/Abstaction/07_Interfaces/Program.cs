using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            instance.Method1();
            instance.Method2();

            IInterface1 interface1 = new DerivedClass();
            Interface2 interface2 = new DerivedClass();

            interface1.Method1();
            //interface1.Method2();  Недоступно

            interface2.Method2();
        }
    }
}
