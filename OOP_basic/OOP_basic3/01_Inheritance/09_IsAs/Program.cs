using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_IsAs
{

    class classA { }

    class classB : classA { }



    class Program
    {
        static void Main(string[] args)
        {
            classB b = new classB();
            classA a = null;

            if (b is classA)
                a = (classA)b;
            else
                a = null;

            a = b as classA;

        }
    }
}
