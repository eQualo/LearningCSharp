using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interfaces
{
    //Наследование от класса и интерфейса с одинак сигнатурами

    interface IInterface
    {
        void Method();
    }

    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("Base meth");
        }
    }

    class DerivedClass : BaseClass, IInterface
    {
        //Реализация метода необязательна, т.к. Он уже реализован в BaseClass

        public new void Method()
        {
            Console.WriteLine("Der meth");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();

            IInterface interface1 = derivedClass as IInterface;
            interface1.Method();

            BaseClass baseClass = derivedClass as BaseClass;
            baseClass.Method();
        }
    }
}
