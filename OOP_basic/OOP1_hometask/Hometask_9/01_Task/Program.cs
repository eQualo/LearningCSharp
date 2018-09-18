using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Task
{
    public delegate double MyDelegate (int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {

            MyDelegate myD = new MyDelegate(delegate(int a, int b, int c) { return (double)(a + b + c) / 3; });

            double d;
            d = myD(1, 2, 1);
            Console.WriteLine(d);


            myD = delegate(int a, int b, int c) { return (double)(a + b + c) / 3; };
            d = myD(1, 2, 2);
            Console.WriteLine(d);


            myD = (a, b, c) => { return (double)(a + b + c) / 3; };
            d = myD(1, 2, 3);
            Console.WriteLine(d);


            myD = (a, b, c) =>  (double)(a + b + c) / 3;
            d = myD(1, 2, 4);
            Console.WriteLine(d);
        }
    }
}
