using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        //Конструктор по умолчанию
        //public DerivedClass()
        //{

        //}


        //Пользовательский конструктор
        //при создании объекта производного класса, конструктор производного класса автоматически вызовет конструктор
        //по умолчанию базового класса. Конструктор базового класса присвоит всем данным какие-то свои безопасные значения
        //После начнет работу конструктор производного класса, который повторно будет опрделять значения для унаследованных членов (ДВОЙНАЯ РАБОТА!)
        public DerivedClass(int number1, int number2)
        {
            //Инициализируем поле базового класса
            this.baseNumber = number1;

            //Инициазируем поле производного класса
            this.derivedField = number2;
        }
    }
}
