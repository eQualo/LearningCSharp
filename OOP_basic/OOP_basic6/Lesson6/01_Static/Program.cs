using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            NoStaticClass noStatic = new NoStaticClass(1);
            NoStaticClass noStatic2 = new NoStaticClass(2);

            noStatic.Method();
            noStatic2.Method();

            NoStaticClass.field = 1;

            noStatic.Method();
            noStatic2.Method();
        }
    }
}
