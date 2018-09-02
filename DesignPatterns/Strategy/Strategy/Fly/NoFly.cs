using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Fly
{
    public class NoFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("---");
        }
    }
}
