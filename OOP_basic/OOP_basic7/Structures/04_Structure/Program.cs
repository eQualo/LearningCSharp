using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Structure
{
    struct MyStruct
    {
        public int field;

        public MyStruct(int value)
        {
            Console.WriteLine("ctor");
            this.field = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct(); //Сработает, хотя в случае класса бы не сработало
        }
    }
}
