using System;

namespace _01_Taks
{
    class Vehicle
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        Random rand = new Random();

        public Vehicle()
        {
            this.X = rand.NextDouble() * Math.PI;
            this.Y = rand.NextDouble() * Math.PI;
            this.Price = rand.NextDouble() * 1000;
            this.Speed = rand.NextDouble() * 300;
            this.Year = rand.Next(2000, 2018);
        }

    }

    class Plane : Vehicle
    {
        public int PassangeerCount { get; set; }
        public double Height { get; set; }

        public Plane() : base()
        {
            this.PassangeerCount = 100;
            this.Height = 10000;
        }
    }

    class Ship : Vehicle
    {
        public int PassengeerCount { get; set; }
        public string Port { get; set; }

        public Ship() : base()
        {

        }
    }

    class Car : Vehicle
    {
        public Car() : base()
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i<3; i++)
            {
                Ship ship = new Ship()
                {
                    PassengeerCount = 1500,     //Блок инициализации
                    Port = "London",
                };
                Console.WriteLine("Coord: X = {0}, Y = {1}\nPrice = {2}\nYear = {3}\nSpeed = {4}\nPassangeers = {5}\nPort: {6}", ship.X, ship.Y, ship.Price, ship.Year, ship.Speed, ship.PassengeerCount, ship.Port);
                Console.WriteLine("-", 30);
            }

            Console.ReadKey();

        }
    }
}
