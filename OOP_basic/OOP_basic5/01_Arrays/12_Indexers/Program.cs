using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            BaseClass baseClass = derivedClass;

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(baseClass[i]);
            }
        }
    }
}
