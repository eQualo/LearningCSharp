using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction
{
    abstract class AbstractBaseClass
    {

        //1
        //Обычнфй метод - передается производному как при обычном наследовании (мб ЗАМЕЩЕН)
        public void SimpleMethod()
        {
            Console.WriteLine("AbsCl.SimpleMethod");
        }

        //2
        //Виртуальный метод передается производному классу как при наследовании от конкретоного класса (мб ПЕРЕОПРЕДЕЛЕН или ЗАМЕЩЕН)
        public virtual void VirtualMethod()
        {
            Console.WriteLine("AbsCl.VirtualMethod");
        }

        //3
        //Абстрактный метод - РЕАЛИЗУЕТСЯ в производном классу
        abstract public void AbstractMethod();
    }
}
