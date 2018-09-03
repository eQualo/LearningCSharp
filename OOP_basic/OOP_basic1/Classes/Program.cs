using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Передача экземпляра класса в качестве аргумента метода

namespace Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Вызван метод класса MyClass");
        }
    }

    class MyClass2
    {
        //На 22 строке создается метод CallMeyhod который примениет агрумент типа MyClass и ничего не возвращает
        public void CallMethod(MyClass my)
        {
            my.Method();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            MyClass2 my2 = new MyClass2();

            my2.CallMethod(my);

            //создание экземпляра по слабой ссылке (без присваивания переменной)
            new MyClass().Method();

            Console.ReadKey();
        }
    }
}
