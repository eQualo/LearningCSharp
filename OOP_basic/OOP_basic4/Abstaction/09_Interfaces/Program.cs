using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();
            instance.Method1();
            instance.Method2();

            Console.WriteLine(new string('-', 30));

            BaseClass instanse1 = instance as BaseClass;
            instanse1.Method();     //Другие два метода недоступны

            IInterface1 instance2 = instance as IInterface1;
            instance2.Method1();    //Другие два метода недоступны

            IInterface2 instance3 = instance2 as IInterface2;
            instance3.Method2();    //Другие два метода недоступны

            IInterface2 instance4 = instanse1 as IInterface2;
            instance4.Method2();

            Console.WriteLine(new string('-', 30));
            BaseClass inst = new BaseClass();
            IInterface2 inst1 = inst as IInterface2; //А вот это недопустимо, потому что даункаст без апкаста до этого?
            inst1.Method2();
        }
    }
}
