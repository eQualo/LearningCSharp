using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass_1 instance = new PartialClass_1();

            instance.CallPartialMethod();

            Console.ReadKey();
        }
    }
}
