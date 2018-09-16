using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Structure
{
    struct MyStruct
    {
        private int field;

        //Если в стр-ре имеются члены, кот. обращ-ся к полю и нет пользовательского к-тора, то треб-ся при создании экземпляра вызывать к-то по умолч
        public int Field
        {
            get { return field; }
            set { field = value; }
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct instance = new MyStruct();

            Console.WriteLine(instance.Field);

            instance.Field = 1;

            Console.WriteLine(instance.Field);


        }
    }
}
