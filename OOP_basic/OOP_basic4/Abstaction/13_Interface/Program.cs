using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Interface
{
    interface IInterface
    {
        void Method();
    }

    abstract class AbstractClass : IInterface
    {
        //abstract public void Method(); - так тоже не ругается, Но тогда необходимо реализовать в ConcreteClass


        //Реализация интерфейса в абстрактном классе не обязательна
        public void Method()
        {
            Console.WriteLine("реализация интерфейса в абстрактном классе");
        }
    }

    
    class ConcreteClass : AbstractClass
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.Method(); 
        }
    }
}
