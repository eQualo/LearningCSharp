using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_VarArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array.GetType());

            var array1 = new[] { 1, 2.24, 3 };
            Console.WriteLine(array1.GetType());
        }
    }
}
