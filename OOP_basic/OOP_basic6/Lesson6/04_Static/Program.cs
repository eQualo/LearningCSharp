using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Static
{
    class NotStaticClass
    {
        static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //NotStaticClass notStaticClass = new NotStaticClass();
            //notStaticClass.Property = 12;

            NotStaticClass.Property = 12;
            Console.WriteLine(NotStaticClass.Property);
        }
    }
}
