using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Program
    {
        public readonly string field = "Hello";

        public Program()
        {
            field = "readonly";

            field += "!";
        }

        //to do: 123
        void M()
        {
            field = "123"; //ERROR
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            program.field = "123123"; //ERROR  
        }
    }
}
