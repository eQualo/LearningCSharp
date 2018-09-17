using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Task3
{
    static class Sort
    {
        public static void SortIntArray(this int[] array)
        {
            if(array.Length == 0)
                return;
            int buf;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        buf = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buf;
                    }                       
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 0, 5, 2, 4 };
            for(int i=0;i<array.Length;i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
            array.SortIntArray();
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
            foreach(int a in array)
                Console.Write(a + " ");
        }
    }
}
