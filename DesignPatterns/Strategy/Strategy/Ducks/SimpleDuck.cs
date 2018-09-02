using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Quack;

namespace Strategy
{
    public class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Simple duck!");
        }
    }
}
