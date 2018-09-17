using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Task
{
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            MyClass myC = new MyClass();
            MyStruct myS = new MyStruct();

            Console.WriteLine(myC.change);
            Console.WriteLine(myS.change);

            myC.change = "не изменено";
            myS.change = "не изменено";

            Console.WriteLine(myC.change);
            Console.WriteLine(myS.change);

            Program.ClassTaker(myC);
            Program.StructTaker(myS);

            Console.WriteLine(myC.change);
            Console.WriteLine(myS.change);


        }
    }
}
