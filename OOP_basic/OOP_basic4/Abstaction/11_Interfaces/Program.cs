using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interfaces
{
    class Program
    {
        interface IInterface1
        {
            void Method();
        }

        interface IInterface2 : IInterface1
        {
            new void Method();
        }

        class ConcreteClass : IInterface2
        {
            void IInterface1.Method()
            {
                Console.WriteLine("Реализация инт1");
            }
            void IInterface2.Method()
            {
                Console.WriteLine("Реализация инт2");
            }
        }
        static void Main(string[] args)
        {
            ConcreteClass concreteClass = new ConcreteClass();

            //Upcast needed
            IInterface1 interface1 = concreteClass as IInterface1;
            interface1.Method();
        }
    }
}
