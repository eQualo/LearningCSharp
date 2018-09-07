using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SealedMethods
{
    partial class A
    {
        public virtual void Method1() { Console.WriteLine("1"); }
        public virtual void Method2() { Console.WriteLine("2"); }
    }
    partial class A
    {

    }

    class B : A
    {
        public sealed override void Method1()
        {
            Console.WriteLine("1b");
        }

        public override void Method2()
        {
            Console.WriteLine("2b");
        }
    }

    class C : B
    {
        //public override void Method1() { }   ERROR

        public override void Method2()
        {
            Console.WriteLine("2c");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.Method1();
            c.Method2();

            Console.ReadKey();
        }
    }
}
