using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NestedClass
{
    class MyClass
    {
        public class NestedClass
        {
            public void Nethod()
            {
                Console.WriteLine("Nested");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.NestedClass instance= new MyClass.NestedClass();
            instance.Nethod();
        }
    }
}
