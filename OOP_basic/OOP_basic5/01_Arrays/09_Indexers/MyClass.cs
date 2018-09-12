
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _09_Indexers
{
    class MyClass
    {
        private string[] array = new string[5];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else return "get ERROR";
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("set ERROR");
            }
        }
    }
}