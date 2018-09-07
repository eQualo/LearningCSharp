using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_As
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //Upcast
            BaseClass instanceUp = instance as BaseClass;
            if(instanceUp != null)
                instance.Method();

            //Downcast
            DerivedClass instanceDown = instanceUp as DerivedClass;
            if(instanceDown != null)
                instance.Method();

            Console.ReadKey();
        }
    }
}
