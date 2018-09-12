using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            my[1, 1] = 2;
            Console.WriteLine(my[1, 1]);
            Console.WriteLine(my[0, 0]);
        }
    }
}
