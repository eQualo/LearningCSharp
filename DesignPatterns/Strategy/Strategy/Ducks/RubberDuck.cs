using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Quack;
using Strategy.Fly;

namespace Strategy.Quack
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyBehavior = new NoFly();
        }
        public override void Display()
        {
            Console.WriteLine("Rubber duck!");
        }
    }
}
