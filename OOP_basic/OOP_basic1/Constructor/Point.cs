using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Point
    {
        //fields
        private int x, y;

        //properties
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        //Constructor (default). Initialize default values
        public Point()
        {
            Console.WriteLine("Default construcror!");
        }

        //User constructor. Initialize fields with another values
        public Point(int x, int y)
        {
            Console.WriteLine("User constructor!");
            this.x = x;
            this.y = y;
        }
    }
}
