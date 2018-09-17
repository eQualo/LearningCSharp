using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _05_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "qwery";
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Contains("r"));
            string s1 = "123", s2 = "234", s3;
            s3 = s1 + s2; //Эквивалент String.Concat(s1, s2);
            Console.Beep(1000, 3000);
            
        }
    }
}
