using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Structure
{
    struct MyStruct
    {
        public static int Field
        {
            get;
            set;
        }

        public static void Show()
        {
            Console.WriteLine(Field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct.Show(); //инициализация статич полей необязательна
        }
    }
}
