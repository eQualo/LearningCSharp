using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask
{
    class Printer
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class PrinterRed : Printer
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class PrinterBlue : Printer
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
