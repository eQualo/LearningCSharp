using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AbstractClass
{

    abstract class AbstractClass
    {
        //Static fabric method
        public static AbstractClass GetConcreteClass()
        {
            return new ConcreteClass();
        }

        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Method from Concrete");
        }

        static ConcreteClass()
        {
            Console.WriteLine("Static concrete ctor");

        }

        public ConcreteClass()
        {
            Console.WriteLine("Concrete ctor");
        }
        public void M()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = AbstractClass.GetConcreteClass();
            instance.Method();
            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.M();
        }
    }
}
