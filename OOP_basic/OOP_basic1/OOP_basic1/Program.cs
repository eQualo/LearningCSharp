using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basic1
{
    class MyClass
    {
        private string field = null;

        public void SetField(string value)  //Mutator (метод-мутатор) (setter)
        {
            field = value;
        }
        public string GetField()    //Accessor (getter)
        {
            return field;
        }
    }

    class MyClass1
    {
        private string field = null;

        public string Field
        {
            set   //public void SetField(string value)  //Mutator (метод-мутатор) (setter)
            {
                field = value;
            }
            get ////Accessor (getter)
            {
                return field;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            MyClass1 instance1 = new MyClass1();

            instance1.Field = "123";

            Console.WriteLine(instance1.Field);

            Console.ReadKey();
        }
    }
}
