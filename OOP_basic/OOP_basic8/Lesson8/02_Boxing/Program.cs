using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Boxing
{
	struct MyStruct
	{
		public void Method()
		{
			Console.WriteLine("Method");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			MyStruct my = new MyStruct();

			//boxing
			ValueType boxed = my;
			my.Method();

			//Unboxing
			MyStruct unbox = (MyStruct)boxed;

			unbox.Method();
		}
	}
}
