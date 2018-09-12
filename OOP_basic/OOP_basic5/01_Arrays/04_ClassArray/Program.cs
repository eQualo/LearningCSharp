using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ClassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3 };

            Array array = vector as Array; //безопасное приведение к базовому типа Array
        }
    }
}
