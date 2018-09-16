using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Nested
{
    class MyClass
    {
        private static int field = 0;

        public class NestedClass
        {
            public void Method(int a)
            {
                field = a;
                Console.WriteLine(field);
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
