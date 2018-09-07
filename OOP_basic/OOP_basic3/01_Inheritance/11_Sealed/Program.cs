using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Sealed
{
    sealed class SealedClass
    {

    }

    class A : SealedClass // ERROR!
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
