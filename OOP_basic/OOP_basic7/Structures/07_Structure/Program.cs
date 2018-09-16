using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Structure
{
    struct MyStruct
    {
        public int field;

        //Пользовательский кто с пар-ми
        public MyStruct(int value)
        {
            this.field = value;
            Console.WriteLine(value);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра без вызова к-тора
            MyStruct instance;

            //Нельзя использовать неинициал перем
            //Т.к. к-то не вызывался
            Console.WriteLine(instance.field);
        }
    }
}
