using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hometask
{
    class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public void ShowAddress()
        {
            Console.WriteLine("Index: {0}", this.Index.ToString());
            Console.WriteLine("Country: {0}", this.Country);
            Console.WriteLine("City: {0}", this.City);
            Console.WriteLine("Street: {0}", this.Street);
            Console.WriteLine("House: {0}", this.House.ToString());
            Console.WriteLine("Apartment: {0}", this.Apartment.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = 333333;
            address.Country = "Russia";
            address.City = "Reutov";
            address.Street = "XXX";
            address.House = 10;
            address.Apartment = 67;

            address.ShowAddress();

            Console.ReadKey();

        }
    }
}
