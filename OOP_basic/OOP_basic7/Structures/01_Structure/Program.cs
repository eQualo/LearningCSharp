using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Structure
{
    struct MyStruct
    {
        public int field;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct instance;

            instance.field = 1;

            Console.WriteLine(instance.field);
        }
    }
}
