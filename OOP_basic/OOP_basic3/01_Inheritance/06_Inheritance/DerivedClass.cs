using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    class DerivedClass : BaseClass
    {
        //Замещение метода
        public void Method()
        {
            Console.WriteLine("Method from derived class");
        }
    }
}
