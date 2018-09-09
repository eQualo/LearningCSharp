using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfaces
{
    class Program
    {
        interface IInterface
        {
            void Method();
        }

        class MyClass : IInterface
        {
            public void Method()
            {
                Console.WriteLine("Реализация интерфейса");
            }
        }

        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.Method();

            IInterface interf = new MyClass();
            interf.Method();
        }
    }
}
