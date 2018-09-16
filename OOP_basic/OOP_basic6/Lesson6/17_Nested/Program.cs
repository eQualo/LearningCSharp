using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Nested
{
    public class MyClass
    {
        public class Nested : BaseClass
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Nested meth");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested nested = new MyClass.Nested();
            nested.MethodFromBase();
            nested.MethodFromNested();
        }
    }
}
