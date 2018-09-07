using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Virtual
{
    class DerivedClass : BaseClass
    {
        //Переопределение метода базового класса
        public override void Method()
        {
            Console.WriteLine("Method from derived");
            
        }
    }
}
