using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    class DerivedClass : IInterface1, IInterface2
    {

        //При наследовании от интерфейсов, содержащий одинаковый метод, указываем его явно
        void IInterface1.Method()
        {
            Console.WriteLine("Реализация интерфейса 1");
        }
        void IInterface2.Method()
        {
            Console.WriteLine("Реализация интрефейса 2");
        }
    }
}
