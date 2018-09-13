using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }

        public static void ExtensionMethod(this string value, string value1)
        {
            Console.WriteLine(value + value1);
        }

        public static int ExtensionMethod(this int value)
        {
            Console.WriteLine(value);
            return value+1;
        }
        public static void ExtensionMethod(this string value, string value1, string value2)
        {
            Console.WriteLine(value + value1 + value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "text";

            ExtensionClass.ExtensionMethod(text);
            int k = 3;
            int d = ExtensionClass.ExtensionMethod(k);
            "hello ".ExtensionMethod(text);
            Console.WriteLine(d);
            33.ExtensionMethod();
            "1".ExtensionMethod(text, "qwe");
        }
    }
}
