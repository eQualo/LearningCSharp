using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Singleton
    {
        private static Singleton instance = null;

        protected Singleton()
        {
            Console.WriteLine("singlton ctor");
        }

        public static Singleton GetSingleton()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }

    class Point1D
    {
        protected double xCoord;

        public double XCoord { get { return this.xCoord; } }

        public Point1D(double x)
        {
            xCoord = x;
        }

    }

    class Point2D : Point1D
    {
        protected double yCoord;

        public double YCoord { get { return this.yCoord; } }

        public Point2D(double x, double y)
            : base(x)
        {
            yCoord = y;
        }
    }

    static class StaticExtension
    {
        public static void Print(this int value)
        {
            Console.WriteLine(value);
        }
        public static double Sqrt(this double value)
        {
            return Math.Sqrt(value);
        }
        //public static double Distance(this)
        //{
        //    return Math.Sqrt(
        //}

        public static double DistanceTo(this Point1D p1, Point1D p2)
        {
            return Math.Abs(p1.XCoord - p2.XCoord);
        }

        public static double DistanceTo(this Point2D p1, Point2D p2)
        {
            return Math.Sqrt(Math.Pow((p1.XCoord - p2.XCoord), 2) + Math.Pow((p1.YCoord - p2.YCoord), 2));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Singleton instance1 = Singleton.GetSingleton();
            Singleton instance2 = Singleton.GetSingleton();

            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance2.GetHashCode());

            //int k = 10;

            //5.Print();
            //Console.WriteLine(3d.Sqrt());
            //3D.Sqrt();

            //StaticExtension.Print(k);
            //Point1D A = new Point1D(4d);
            //Point1D B = new Point1D(2d);

            //Point2D C = new Point2D(1d, 1d);
            //Point2D D = new Point2D(3d, 3d);
            
            //double d = 5;
            //d.Sqrt();
            //Console.WriteLine(A.DistanceTo(B));
            //Console.WriteLine(D.DistanceTo(C));
        }
    }
}
