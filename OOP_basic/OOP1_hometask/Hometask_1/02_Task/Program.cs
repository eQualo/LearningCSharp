using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Task
{
    class Rectangle
    {
        double side1;
        double side2;

        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }


        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculator()
        {
            return this.side1 * this.side2;
        }

        double PerimeterCalculator()
        {
            return this.side1 + this.side2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.0, 5.5);

            Console.WriteLine(rect.Area.ToString());
            Console.WriteLine(rect.Perimeter.ToString());
            Console.WriteLine((Math.Pow(2,3).ToString()));
            Console.ReadKey();
        }
    }
}
