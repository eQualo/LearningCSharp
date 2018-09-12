using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Params
{
    class Program
    {
        static void M1 (string st, params int[] array)
        {
            Console.WriteLine(st);
            Console.WriteLine(array[1]);
        }
        static void Main(string[] args)
        {
            M1("123", 1, 2 ,3 ,4);
        }
    }
}
