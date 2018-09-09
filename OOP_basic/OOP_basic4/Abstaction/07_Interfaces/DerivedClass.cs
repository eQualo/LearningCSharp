using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Interfaces
{
    class DerivedClass : IInterface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода 1");
        }
        public void Method2()
        {
            Console.WriteLine("Реализация метода 2");
        }
    }
}
