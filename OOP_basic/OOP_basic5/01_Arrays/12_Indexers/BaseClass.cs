using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Indexers
{
    class BaseClass
    {
        private string[] baseArray = null;

        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "zero";
            baseArray[1] = "one";
            baseArray[2] = "two";
        }

        //Виртуальный индексатор
        public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }
}
