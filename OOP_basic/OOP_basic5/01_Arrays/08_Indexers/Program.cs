using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Indexers
{
    class MyClass
    {
        private int[] array = new int[5];

        //Индексатор
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my[0] = 1;
            my[2] = 1;
            my[3] = 1;
            my[4] = 1;
            my[1] = 1;

            Console.WriteLine(my[2]);
        }
    }
}
