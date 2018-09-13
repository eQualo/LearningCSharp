using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine(store[0]);
            Console.WriteLine(store["вода"]);
            Console.WriteLine(store["123"]);
        }
    }
}
