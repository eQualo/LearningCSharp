using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Delegation
{
    //Техника делегирования
    class A
    {
        public void DoSomething()
        {
            Console.WriteLine("Action");
        }
    }
    class B
    {
        public void DoSomething()
        {
            A a = new A();
            a.DoSomething();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.DoSomething();
        }
    }
}
