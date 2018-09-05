using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Association
{
    class MyClass1
    {
        public MyClass1()
        {
            Console.WriteLine("instance of Myclass1");
        }
    }

    class MyClass2
    {
        private MyClass1 myObj = null;

        //данный метод не является фабричным
        //Так как фабричный метод должен иметь возвращаемое значение типа создаваемого продукта
        public void Method()
        {
            myObj = new MyClass1();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 my = new MyClass2();

            my.Method();

            Console.ReadKey();
        }
    }
}
