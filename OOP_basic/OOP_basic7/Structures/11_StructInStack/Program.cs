using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StructInStack
{
    interface IInterface
    {
        void Method();
    }

    struct MyStruct : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct instance;
            instance.Method();

            ValueType valueType = instance as ValueType;
            Console.WriteLine("inst = {0}", instance.GetHashCode());
            Console.WriteLine("valT = {0}", valueType.GetHashCode());
        }
    }
}
