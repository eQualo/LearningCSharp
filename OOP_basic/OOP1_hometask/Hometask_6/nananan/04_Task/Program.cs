using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Task
{
    class Building
    {
        Apartment[] apartments;

        public Apartment[] Apartments
        {
            get { return this.apartments; }
        }

        public Building(int numOfApartments)
        {
            if (numOfApartments <= 0)
            {
                Console.WriteLine("Bad num");
                return;
            }
            apartments = new Apartment[numOfApartments];

            Random rand = new Random();

            for (int i = 0; i < numOfApartments; i++)
            {
                apartments[i] = new Apartment(i, Convert.ToBoolean(rand.Next(2)));
            }
        }
        public void ShowFree()
        {
            Console.WriteLine("Free apartments are:");
            for (int i = 0; i < this.Apartments.Length; i++)
            {
                if (this.Apartments[i].IsFree == true)
                    Console.Write("{0}, ", apartments[i].Number);
            }
        }

        public class Apartment
        {
            int number;
            bool isFree;
            public int Number
            {
                get { return this.number; }
            }
            public bool IsFree
            {
                get { return this.isFree; }
            }
            public Apartment(int number, bool isFree)
            {
                this.isFree = isFree;
                this.number = number;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(20);
            building.ShowFree();
        }
    }
}
