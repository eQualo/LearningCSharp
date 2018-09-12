using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my[0] = "123";
            my[5] = "141";
            Console.WriteLine(my[-1]);
        }
    }
}
