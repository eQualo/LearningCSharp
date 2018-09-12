using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = {
                                { { 1, 2}, {3, 4 } },
                                { { 5, 6}, {7, 8 } }
                             };
            int k = array[0,1,1];
            Console.WriteLine(k);
        }
    }
}
