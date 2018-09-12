using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3 };
            jagged[2] = new int[] { 4, 5, 6 };

            for(int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j <jagged[i].Length; j++)
                    Console.Write(jagged[i][j]);
                Console.WriteLine();
            }
        }
    }
}
