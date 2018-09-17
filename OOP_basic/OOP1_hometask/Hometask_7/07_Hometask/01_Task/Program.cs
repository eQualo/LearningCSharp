using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Task
{
    struct S
    {
        public static int field1 = 1;
        public int field2;
        public int field3;
        public int F { get; set; }

        //public S(int k)
        //{
        //    this.field2 = 1;
        //    this.field3 = 2;
        //}
        public void Method()
        {
            Console.WriteLine(this.field2);
            Console.WriteLine("qweqwe");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            S s = new S();// = new S { field2 = 1, field3 = 2 };// = new S();// = new S();
            //Console.WriteLine(s.field2);
            //s.field2 = 4;
            //s.field3 = 5;
            //Console.WriteLine(S.field1);
            //s.Method();
            //Console.WriteLine(s.field2);
            //Console.WriteLine(s.field3);

            //S s1 = new S(1);
            
            //Console.WriteLine(s1.field2);
            //Console.WriteLine(s1.field3);
            s.field3 = 2;
            s.field2 = 1;
            s.F = 1;
            s.Method();
        }
    }
}
