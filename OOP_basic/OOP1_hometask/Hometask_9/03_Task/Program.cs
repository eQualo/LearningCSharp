using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Task
{
    public delegate int MyDelegate();
    public delegate double Mydelegate1(MyDelegate[] array);
    class MyClass
    {
        public int Method1()
        {
            Console.WriteLine("Method1");
            return 1;
        }
        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 2;
        }
    }

    static class MyClass2
    {
        public static int Method3()
        {
            Console.WriteLine("Method3");
            return 3;
        }
        public static int Method4()
        {
            Console.WriteLine("Method4");
            return 4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyDelegate[] arrayD = new MyDelegate[3];
            arrayD[0] = () => myClass.Method1();
            arrayD[0] += () => MyClass2.Method3();
            arrayD[1] = () => MyClass.Method2();
            arrayD[2] = () => MyClass2.Method4();

            Console.WriteLine("Delegates are:");
            foreach (MyDelegate myD in arrayD)
            {
                Console.WriteLine(myD.Invoke());
            }

            Mydelegate1 myD1 = (MyDelegate[] array) => (double)(array[0]() + array[1]() + array[2]())/3;

            Console.WriteLine(myD1.Invoke(arrayD));
        }
    }
}
