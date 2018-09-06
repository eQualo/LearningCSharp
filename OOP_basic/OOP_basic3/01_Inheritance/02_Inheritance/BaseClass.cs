using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance
{
    class BaseClass
    {
        //Открытое поле
        public string publicField = "BaseClass.publicField";

        //закрытое поле
        private string privateField = "BaseClass.privateField";

        //Защищенное поле
        protected string protectedField = "BaseClass.prtectedField";

        public void Show()
        {
            Console.WriteLine(this.privateField);
        }
    }
}
