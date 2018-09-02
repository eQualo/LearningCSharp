using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Fly
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings!");
        }
    }
}
