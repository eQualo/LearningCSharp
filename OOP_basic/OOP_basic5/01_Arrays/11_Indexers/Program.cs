using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[5]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["sun"]);
            Console.WriteLine(dictionary["123"]);
        }
    }
}
