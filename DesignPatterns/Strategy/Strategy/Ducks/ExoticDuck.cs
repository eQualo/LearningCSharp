using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Quack;

namespace Strategy
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            quackBehavior = new ExoticQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Exotic duck!");
        }

    }
}
