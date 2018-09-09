using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction
{
    class ConcreteDerivedClass : AbstractBaseClass
    {
        //Переопределяем вируальный метод
        //Если мы не переопределили, будет использоватся метод из базового класса
        public override void VirtualMethod()
        {
            Console.WriteLine("DerCl.VirtualMethod");
        }

        //Реализация абстрактного метода
        public override void AbstractMethod()
        {
            Console.WriteLine("DerCl.AbstractMethod");
        }
    }
}
