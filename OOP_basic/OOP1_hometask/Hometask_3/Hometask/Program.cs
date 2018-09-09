using System;

namespace Hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterRed instance = new PrinterRed();
            instance.Print("I");

            //UpCast
            Printer instanceUp = instance as Printer;
            if (instanceUp != null)
                instanceUp.Print("love");

            //DownCast
            PrinterBlue instanceDown = instanceUp as PrinterBlue;
            if (instanceDown != null)
                instanceDown.Print("you!");

            Console.ReadKey();
        }
    }
}
