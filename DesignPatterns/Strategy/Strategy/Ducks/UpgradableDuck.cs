using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Fly;
using Strategy.Quack;

namespace Strategy.Ducks
{
    class UpgradableDuck : DuckBase
    {
        public UpgradableDuck()
        {
            flyBehavior = new NoFly();
            quackBehavior = new NoQuack();
        }

        private IQuackable NoQuack()
        {
            throw new NotImplementedException();
        }

        private IFlyable NoFly()
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine("Upgradable duck!");
        }
    }
}
