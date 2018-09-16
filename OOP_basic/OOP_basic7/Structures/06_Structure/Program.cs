using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Structure
{
    struct MyStruct
    {
        public int field;

        static MyStruct()
        {
            
            Console.WriteLine("Static ctor");
        }

        public MyStruct(int value)
        {
            Console.WriteLine("Ctor");
            this.field = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct(10) { field = 0 };
            Console.WriteLine(myStruct.field);
        }
    }
}
