using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstraction
{
    //Абстрактный класс
    abstract class AbstractClass
    {
        public abstract void Method();

        public AbstractClass()
        { }
    }

    //Конкретный класс
    class ConcreteClass : AbstractClass
    {
        public ConcreteClass()
        {

        }
        public override void Method()
        {
            Console.WriteLine("Implementation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Если мы создаем экземпляры конкретных классов, которые реализуют ( наследуют) абстрактный класс, мы должны приводить их к базовому
            AbstractClass instance = new ConcreteClass();

            instance.Method();


        }
    }
}
