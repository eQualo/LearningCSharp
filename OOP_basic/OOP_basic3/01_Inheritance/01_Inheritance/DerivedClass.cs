using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inheritance
{
    class DerivedClass : BaseClass
    {
        //Конструктор
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
    }
}
