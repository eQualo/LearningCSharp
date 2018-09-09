using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstarction
{
    class Program
    {
        abstract class AbstractClassA
        {
            public abstract void OperationA();
        }

        abstract class AbstractClassB : AbstractClassA
        {
            public abstract void OperationB();
            public override void OperationA()
            {
                Console.WriteLine("123");
            }
        }

        class ConcreteClass : AbstractClassB
        {
            public override void OperationA()
            {
                Console.WriteLine("OperationA");
                base.OperationA();
            }
            public override void OperationB()
            {
                Console.WriteLine("OperationB");
            }
        }
        static void Main(string[] args)
        {

            AbstractClassA inst = new ConcreteClass();

            inst.OperationA();
            //inst.OperationB(); // Недоступен, т.к. мы приводились к А, т.е. мы инкапсулировали ОперэйшнВ
            AbstractClassB instance = new ConcreteClass();

            instance.OperationA();
            instance.OperationB();
        }
    }
}
