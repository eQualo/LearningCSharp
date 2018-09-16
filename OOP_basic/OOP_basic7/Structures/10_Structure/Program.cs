using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Structure
{
    struct ZipCode
    {
        int fiveDigitCode;
        int plusFourExtension;

        public ZipCode(int fiveDigitCode, int plusFourExtension)
        {
            this.fiveDigitCode = fiveDigitCode;
            this.plusFourExtension = plusFourExtension;
        }

        public ZipCode(int fiveDigitCode)
            : this(fiveDigitCode, 0)
        {

        }

        public int FiveDigiteCode
        {
            get { return fiveDigitCode; }
        }
        public int PlusFourExtension
        {
            get { return plusFourExtension; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ZipCode zipCode = new ZipCode(12345, 1234);

            Console.WriteLine(zipCode.FiveDigiteCode);
            Console.WriteLine(zipCode.PlusFourExtension);
        }
    }
}
