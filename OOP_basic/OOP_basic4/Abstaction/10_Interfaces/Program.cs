using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    class Program
    {
        interface IInterface1
        {
            void Method1();
        }
        interface IInterface2 : IInterface1
        {
            void Method2();
        }

        class ConcreteClass : IInterface2
        {
            public void Method1()
            {
                Console.WriteLine("Method1");
            }
            public void Method2()
            {
                Console.WriteLine("Method2");
            }
        }

        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method1();
            instance.Method2();

            IInterface1 instance2 = instance as IInterface1;
            instance2.Method1();

            IInterface2 instance3 = instance2 as IInterface2;
            instance3.Method1();
            instance3.Method2();

            Console.WriteLine(new string('-', 30));

            ConcreteClass concreteClass = new ConcreteClass();
            IInterface2 interface2 = concreteClass as IInterface2;
            interface2.Method1();
            interface2.Method2();
        }
    }
}
