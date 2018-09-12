using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Indexers
{
    class DerivedClass : BaseClass
    {
        private string[] derivedArray = null;

        public DerivedClass()
        {
            derivedArray = new string[3];
            derivedArray[0] = "00";
            derivedArray[1] = "11";
            derivedArray[2] = "22";
        }
        public override string this[int index]
        {
            get
            {
                return base[index] + " - " + this.derivedArray[index];
            }
        }
    }
}
