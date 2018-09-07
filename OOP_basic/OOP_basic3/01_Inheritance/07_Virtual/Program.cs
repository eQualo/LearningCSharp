using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //UpCast
            BaseClass instanceUp = instance;
            instanceUp.Method();

            //DownCast
            DerivedClass instanceDown = (DerivedClass)instanceUp;
            instance.Method();


            Console.ReadKey();
        }
    }
}
