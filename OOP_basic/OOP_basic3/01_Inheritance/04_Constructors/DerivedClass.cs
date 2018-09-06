using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Constructors
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        //Конструктор по умолчанию
        public DerivedClass()
        {

        }
         
        //Пользовательский конструктор
        //Вызвается пользовательский конструктор базового класса, который инициализирует поле
        //Повторно инициализировать значения унаследованным членам не требуется
        public DerivedClass(int number1, int number2) 
            : base(number1)
        {
  
            //Инициазируем поле производного класса
            this.derivedField = number2;
        }
    }
}
