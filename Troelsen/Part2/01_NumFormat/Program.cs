using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_NumFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 99999;
            Console.WriteLine("99999 in different formats:");
            Console.WriteLine("c format: {0:c}", num);
            Console.WriteLine("d9 format: {0:d9}", num);
            Console.WriteLine("f format: {0:f3}", num);
            Console.WriteLine("E format: {0:E}", num);
            Console.WriteLine("e format: {0:e}", num);
            Console.WriteLine("X format: {0:X}", num);
            Console.WriteLine("x format: {0:x}", num);
        }
    }
}
