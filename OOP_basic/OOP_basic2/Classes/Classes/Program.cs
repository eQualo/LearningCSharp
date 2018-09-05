using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass_1 instance = new PartialClass_1();
            instance.MethodFromPart1();
            instance.MethodFromPart2();


            Console.ReadKey();
        }
    }
}
