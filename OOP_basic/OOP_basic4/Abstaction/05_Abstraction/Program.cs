using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Abstraction
{
    abstract class AbstractClass
    {

        string a = "123";
        int d = 12;
        //Конструктор (отрабатывает первым)
        public AbstractClass()
        {
            Console.WriteLine("1 AbsCl()");


            //Вызывается реализация метода из производного класса  - ConcreteClass
            //Техника шаблонного метода (основная задача - инкапсулировать алгоритм)
            this.AbstractMethod();

            Console.WriteLine("2 AbsCl()");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "FIRST";
        int k = 10;

        //Конструктор (отрабатывает вторым)
        public ConcreteClass()
        {
            Console.WriteLine("3 ConcCl");
            s = "SECOND";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Реализация метода в производном {0}", s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            Console.WriteLine(new string('-', 30));

            instance.AbstractMethod();
        }
    }
}
