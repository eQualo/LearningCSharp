using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Quack;
using Strategy.Fly;

namespace Strategy
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehavior;
        protected IQuackable quackBehavior;

        public DuckBase()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new SimpleQuack();
        }

        public void SetQuackBehavior(IQuackable newQuackBehavior)
        {
            quackBehavior = newQuackBehavior;
        }
        public void SetFlyBehavior(IFlyable newFlyBehavior)
        {
            flyBehavior = newFlyBehavior;
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }

        public void Fly()
        {
            flyBehavior.Fly();
        }
        public void Swim()
        {
            Console.WriteLine("Swim!");
        }

        public abstract void Display();
    }
}
