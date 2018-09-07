using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Task
{
    class Point
    {
        int x;
        int y;
        string name;


        public int X
        {
            get
            {
                return this.x;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }

    class Figure
    {

        Point[] point;
        string type;
        double perimeter;

        public string Type
        {
            get
            {
                return type;
            }
        }
        double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        public Figure(Point A, Point B, Point C)
        {
            this.type = "triangle";
            point = new Point[3];
            this.point[0] = A;
            this.point[1] = B;
            this.point[2] = C;
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.type = "tetragon";
            point = new Point[4];
            this.point[0] = A;
            this.point[1] = B;
            this.point[2] = C;
            this.point[3] = D;
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.type = "octagon";
            point = new Point[5];
            this.point[0] = A;
            this.point[1] = B;
            this.point[2] = C;
            this.point[3] = D;
            this.point[4] = E;
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.Y - B.Y, 2) + Math.Pow(A.X - B.X, 2));
        }

        void PerimeterCalculator()
        {
            for (int i = 0; i < point.Length-1; i++)
            {
                this.perimeter += this.LengthSide(point[i], point[i + 1]);
            }
            this.perimeter += this.LengthSide(point[point.Length-1], point[0]);
        }

        public void ShowInfo()
        {
            PerimeterCalculator();
            Console.WriteLine("Type: {0}", this.Type);
            Console.WriteLine("Perimeter: {0}", this.Perimeter);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2, "a");
            Point b = new Point(2, 4, "b");
            Point c = new Point(-3, -6, "c");
            Figure figure = new Figure(a, b , c);
            
            figure.ShowInfo();

            Console.ReadKey();
        }
    }
}
