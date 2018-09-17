using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _04_DateTimeandTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dates and times");

            DateTime dt = new DateTime(2016, 8, 16);
            Console.WriteLine("The day is: {0}, {1}", dt.DayOfWeek, dt.TimeOfDay);

            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;
            Console.WriteLine("{0}{1}{2}", dt1.Day, dt1.Month, dt1.Year);
            Console.WriteLine("{0} {1}",dt1.ToLongDateString(), dt1.ToLongTimeString());

            // Этот конструктор принимает часы, минуты и секунды.
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy =
            BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            // Значение biggy
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            // biggy четное?
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            // biggy степень 2?
            BigInteger reallyBig = BigInteger.Multiply(biggy,
            BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            // Значение reallyBig
        }
    }
}
