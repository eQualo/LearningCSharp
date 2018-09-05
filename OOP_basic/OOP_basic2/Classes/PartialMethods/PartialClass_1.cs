using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    //первая часть класса
    partial class PartialClass_1
    {
        partial void PartialMethod();   //используется только сигнатура, но нет тела

        partial void MyMethod();    //Этот метод объявлен, но не описан

        //partial int k();    //Ошибка! не могут иметь возвращаемых значений
    }


    //вторая часть класса
    partial class PartialClass_1
    {
        //определение частичного метода
        partial void PartialMethod()
        {
            Console.WriteLine("123");

        }

        //вызов частичного метода через обертку, потому что паршл методы всегда прайват
        public void CallPartialMethod()
        {
            PartialMethod();

            //при вызове нереализованного частичного метода компилятор его проигнорирует
            //и ошибки не будет
            MyMethod();
        }
    }

}

