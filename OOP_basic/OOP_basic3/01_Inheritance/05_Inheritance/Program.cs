using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            //Все переменные видны
            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;
            instance.field4 = 4;
            instance.field5 = 5;

            //Приведение экземпляра DerivedClass к базовому типу BaseClass
            BaseClass newInstance = (BaseClass)instance; //Upcast

            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            Console.WriteLine("Instance id: {0}", instance.GetHashCode());

            Console.WriteLine("newInstance od: {0}", newInstance.GetHashCode());


            Console.ReadKey();
        }
    }
}
