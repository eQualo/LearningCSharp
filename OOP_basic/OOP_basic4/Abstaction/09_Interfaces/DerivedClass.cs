
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _09_Interfaces
{
    class DerivedClass : BaseClass, IInterface1, IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода инт1");
        }

        public void Method2()
        {
            Console.WriteLine("Реалищация метода инт2");
        }
    }
}