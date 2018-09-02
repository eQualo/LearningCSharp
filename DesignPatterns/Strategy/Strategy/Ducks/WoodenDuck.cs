using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Quack;
using Strategy.Fly;

namespace Strategy.Quack
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            flyBehavior = new NoFly();
            quackBehavior = new NoQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Wooden duck!");
        }
    }
}
