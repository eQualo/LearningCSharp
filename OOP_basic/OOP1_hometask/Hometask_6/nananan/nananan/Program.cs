using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nananan
{
    abstract class AbstractClass
    {
        public static AbstractClass FabricMethod()
        {
            Console.WriteLine("here");
            return new ConcreteClass();
        }

        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        static ConcreteClass()
        {
            Console.WriteLine("static concrete ctor");
        }

        public ConcreteClass()
        {
            Console.WriteLine("concrete ctor");
        }

        public override void Method()
        {
            Console.WriteLine("concrete method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = AbstractClass.FabricMethod();

            ConcreteClass instance1 = (ConcreteClass)AbstractClass.FabricMethod();

            instance1.Method();
            Console.WriteLine(instance.GetHashCode());
            Console.WriteLine(instance1.GetHashCode());
        }
    }
}
