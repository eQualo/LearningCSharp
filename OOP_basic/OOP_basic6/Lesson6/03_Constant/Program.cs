using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constant
{
     
    class NotStaticClass
    {
        public const float e = 2.71F;

    }
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass notStaticClass = new NotStaticClass();
            Console.WriteLine(NotStaticClass.e);
        }
    }
}
