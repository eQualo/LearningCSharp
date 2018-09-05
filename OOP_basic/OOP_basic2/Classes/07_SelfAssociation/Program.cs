using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SelfAssociation
{
    class Program
    {

        public void Method()
        {
            Console.WriteLine("Hello!");
        }

        static void Main(string[] args)
        {
            //Program program = new Program();
            Program program = new Program();
            program.Method();

            Console.ReadKey();
        }
    }
}
