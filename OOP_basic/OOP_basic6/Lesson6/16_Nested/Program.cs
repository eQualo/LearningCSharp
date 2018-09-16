using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Nested
{
    class MyClass
    {
        private int field = 0;

        public class NestedClass
        {
            public void Method(int a)
            {
                MyClass instance = new MyClass();
                instance.field = a;
                Console.WriteLine(instance.field);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.NestedClass instance = new MyClass.NestedClass();
            instance.Method(1);

        }
    }
}
