using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Task
{
    public delegate double MyDelegate(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate Add = (x, y) => (double)(x + y);

            MyDelegate Sub = (x, y) => (double)(x - y);

            MyDelegate Mul = (x, y) => (double)(x * y);

            MyDelegate Div = (x, y) =>
            {
                if (y != 0)
                    return (double)(x / y);
                else
                {
                    Console.WriteLine("Divide by zero!");
                    return 0d;
                }
            };


            Console.WriteLine(Add(1, 2));

            Console.WriteLine(Mul.Invoke(1, 2.5));

            Console.WriteLine(Div.Invoke(1, 0));

            Console.WriteLine(Sub(1.15, 4));
        }
    }
}
