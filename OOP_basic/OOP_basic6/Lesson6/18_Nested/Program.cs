using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Nested
{
    public class MyClass : BaseClass
    {
        public class Nested
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
            nested.MethodFromNested();
        }
    }
}
