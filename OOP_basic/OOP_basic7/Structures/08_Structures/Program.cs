using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Structures
{
    struct MyStruct
    {
        public int Prop { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            myStruct.Prop = 1;
            Console.WriteLine(myStruct.Prop);
        }
    }
}
