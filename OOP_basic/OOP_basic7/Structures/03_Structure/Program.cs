using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Structure
{
    struct MyStruct
    {
        public int field;

        //Конструкторы по умолчанию нельзя задавать явно
        //public MyStruct()
        //{

        //}

        //если есть польз к-то, то треб-ся инициал все поля
        public MyStruct(int value)
        {
            Console.WriteLine("ctor");
            this.field = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра структорунеого типа с вызовом к-тора по умолч
            MyStruct insyance = new MyStruct();

            Console.WriteLine(insyance.field);

            MyStruct myStruct = new MyStruct(1);
            Console.WriteLine(myStruct.field);

        }
    }
}
