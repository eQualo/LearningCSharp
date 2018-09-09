using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBaseClass instance = new ConcreteDerivedClass();

            instance.SimpleMethod();
            instance.VirtualMethod();
            instance.AbstractMethod();
        }
    }
}
