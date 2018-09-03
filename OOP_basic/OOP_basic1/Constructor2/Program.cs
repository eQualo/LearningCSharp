
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point("A");
            Console.WriteLine("{0}.X = {1}, {2}.Y = {3}", point.Name, point.X, point.Name, point.Y);

            Console.ReadKey();
        }
    }
}
