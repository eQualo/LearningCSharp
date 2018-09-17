using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            /*byte b1 = 100;
            byte b2 = 250;

            // На этот раз сообщить компилятору о необходимости добавления
            // CIL-кода, необходимого для генерации исключения, если возникает
            // переполнение или потеря значимости.
            //Можно проставлять флаг /cheked для всего проекта, блока (как ниже) или отдельной операции
            try
            {
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            } 

            // Предполагая, что флаг /checked активизирован,
            // этот блок не будет генерировать исключение
            // времени выполнения.
            unchecked{
            byte sum1 = (byte)(b1 + b2);
            Console.WriteLine("sum1 = {0} ", sum1);
            }
            */
            int i = 1;
            int k = ++i + ++i + ++i + ++i;
            Console.WriteLine(i);
            Console.WriteLine(k);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
