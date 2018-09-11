using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interfaces
{
    class Program
    {
        interface IInterface1
        {
            void Method();
        }

        interface IInterface2
        {
            new void Method();
        }

        class ConcreteClass : IInterface1, IInterface2
        {
            public void Method()
            {
                Console.WriteLine("Объединение");
            }
        }
        static void Main(string[] args)
        {
            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.Method();

            IInterface1 interface1 = concreteClass as IInterface1;
            interface1.Method();
        }
    }
}
