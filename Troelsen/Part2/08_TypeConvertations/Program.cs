using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_TypeConvertations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");
            short numb1 = 30000, numb2 = 30000;
            // Явно привести int к short (и разрешить потерю данных).
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            NarrowingAttempt();
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            // Явно привести int к byte (без потери данных).
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }
    }
}
