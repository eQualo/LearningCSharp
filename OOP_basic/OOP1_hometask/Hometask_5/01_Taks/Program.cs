using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Taks
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 1)
                return;
            int[] array = new int[N];

            Random random = new Random();
            for(int i = 0; i<N; i++)
            {
                array[i] = random.Next(0, 10);
            }

            int max, min, sum = 0, arifm;

            min = max = array[0];
            for(int i =0; i<N; i++)
            {
                Console.WriteLine("{0}  ", array[i]);
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
                sum += array[i];
            }
            arifm = sum / N;
            Console.WriteLine(" min {0}, max {1}, sum {2}, arifm {3}", min, max, sum, arifm);


        }
    }
}
