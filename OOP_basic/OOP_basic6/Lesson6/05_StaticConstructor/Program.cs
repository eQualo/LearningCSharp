using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StaticConstructor
{
    class NotStaticClass
    {
        //статические поля readonly должны быть инициализированы в конструкторе
        static readonly long readonlyField = 2;

        public static long ReadonlyField
        {
            get { return NotStaticClass.readonlyField; }
        }

        //Статический конструктор
        static NotStaticClass()
        {
            readonlyField = 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NotStaticClass.ReadonlyField);

        }
    }
}
