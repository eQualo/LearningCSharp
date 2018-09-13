using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Static
{
    class NoStaticClass
    {
        private int Id;
        public static int field;
        private static int k;

        public NoStaticClass(int Id)
        {
            this.Id = Id;
        }

        public void Method()
        {
            Console.WriteLine("Instance{0} field = {1}", Id, field);
        }
    }
}
