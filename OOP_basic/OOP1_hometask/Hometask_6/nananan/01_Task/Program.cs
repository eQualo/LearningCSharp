using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Task
{
    static class Calculator
    {
        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public static double Substaction(double value1, double value2)
        {
            return value1 - value2;
        }

        public static double Division(double value1, double value2)
        {
            if (value2 == 0)
            {
                Console.WriteLine("ERROR! Dividy by 0");
                return 0;
            }
            return value1 / value2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1, 2));
            Console.WriteLine(Calculator.Division(3, 0));
            Console.WriteLine(Calculator.Multiply(2, 3));
        }
    }
}
