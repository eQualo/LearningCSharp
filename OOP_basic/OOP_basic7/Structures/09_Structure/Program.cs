using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Structure
{

    //Пример плохой реализации дизайна структуры
    struct ZipCode
    {
        int fiveDigitCode;
        int plusFourExtension;

        public int FiveDigitCode
        {
            get { return this.fiveDigitCode; }
            set { this.fiveDigitCode = value; }
        }

        public int PlusFourExtension
        {
            get { return this.plusFourExtension; }
            set { this.plusFourExtension = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ZipCode zipCode = new ZipCode();

            zipCode.FiveDigitCode = 12345;
            zipCode.PlusFourExtension = 1234;

            Console.WriteLine(zipCode.FiveDigitCode);
            Console.WriteLine(zipCode.PlusFourExtension);
            
        }
    }
}
