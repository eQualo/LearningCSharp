using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Random random = new Random();
                    array[i, j] = random.Next(0, 10);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write ("a[{0}][{1}] = {2}\t", i, j, array[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
