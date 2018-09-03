using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using default constructor
            Point pointA = new Point();
            Console.WriteLine("pointA.x = {0} pointA.y = {1}", pointA.X, pointA.Y);

            Console.WriteLine(new string('-', 30));

            //Using users constructor
            Point pointB = new Point(100, 200);
            Console.WriteLine("pointB.x = {0} pointB.y = {1}", pointB.X, pointB.Y);

            Console.ReadKey();
        }
    }
}
