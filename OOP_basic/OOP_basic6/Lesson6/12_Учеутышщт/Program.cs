using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Учеутышщт
{
    static class ExtentionClass
    {
        public static void ExtensionMetod(this string value)
        {
            Console.WriteLine(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "text";
            ExtentionClass.ExtensionMetod(text);

            text.ExtensionMetod();
        }
    }
}
