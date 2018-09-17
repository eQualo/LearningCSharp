using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Task
{
    static class IntArrayHelper
    {
        
        public static void Fill(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = value;
        }

        public static void SequenceFill(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = i + 1;
        }

        public static void Print(int[] array)
        {
            for(int i = 0; i<array.Length;i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            IntArrayHelper.SequenceFill(array);
            IntArrayHelper.Print(array);
            IntArrayHelper.Fill(array, 2);
            IntArrayHelper.Print(array);
        }
    }
}
