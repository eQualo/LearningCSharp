using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Boxing
{
	interface IInterface
	{
		void Method();
	}

	struct MyStruct : IInterface
	{
		public void Method()
		{
			Console.WriteLine("Meth");
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
				MyStruct my;

				my.Method();

				IInterface boxed = my;

				boxed.Method();

				MyStruct undox = (MyStruct)boxed;

				undox.Method();
		}
	}
}
