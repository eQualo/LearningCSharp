﻿using System;
using System.Collections.Generic;
using Strategy.Quack;
using Strategy.Fly;
using Strategy.Ducks;
using System.Linq;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubberDuck());

            foreach(var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();
                Console.WriteLine();
            }

            DuckBase upgradableDuck = new UpgradableDuck();
            upgradableDuck.Display();
            upgradableDuck.Swim();
            upgradableDuck.Quack();
            upgradableDuck.Fly();

            upgradableDuck.SetFlyBehavior(new FlyWithWings());
            upgradableDuck.SetQuackBehavior(new ExoticQuack());
            upgradableDuck.Quack();
            upgradableDuck.Fly();
            Console.ReadKey();
        }
    }
}
