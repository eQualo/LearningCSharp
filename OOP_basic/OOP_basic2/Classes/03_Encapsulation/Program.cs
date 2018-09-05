using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulation
{
    //Объект не модет ничего скрывать (инкапсулировать) ничего от другого объекта того же класса
    class MyClass
    {
        MyClass my = null; //создаем ссылку на себя самого

        private void Method()
        {
            Console.WriteLine("Hello");
        }

        public void CallMethod()
        {
            my = new MyClass();

            //private метод виден на экземпляре!
            my.Method();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.CallMethod();
            //my.Method(); НЕДОПУСТИМО
        }
    }
}
