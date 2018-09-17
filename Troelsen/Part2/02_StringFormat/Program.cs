using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            byte k = 10;
            string msg = string.Format("k = {0:X}", k);

            Console.WriteLine(msg);

            k = 20;
            Console.WriteLine(msg);
            System.Int32 m = new System.Int32();
            m = 10;
            Console.WriteLine(m);
            Console.WriteLine("k {0}, msg {1}, m {2}", k.GetType(), msg.GetType(), m.GetType());

            Console.WriteLine("Positive infinity: {0}\nNegative infinity: {1}\n{2}", double.PositiveInfinity, double.NegativeInfinity, double.PositiveInfinity*double.PositiveInfinity);

            char a = 'a';
            Console.WriteLine("char.IsDigit(a) {0}", char.IsDigit(a));
            Console.WriteLine(char.IsSymbol("!!!!!!", 3));
        }
    }
}
