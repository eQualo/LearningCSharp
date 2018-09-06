using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors
{
    class BaseClass
    {
        public int baseNumber;
        //по умолчанию
        public BaseClass()
        {

        }

        //пользовательский
        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
}
