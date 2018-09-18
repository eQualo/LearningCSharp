using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Delegate
{
	delegate MyDelegate Functional(MyDelegate myDelegate1, MyDelegate myDelegate2);
	delegate string MyDelegate();
	class Program
	{
		
		static void Main(string[] args)
		{
			MyDelegate myDelegate1 = () => "Hello ", myDelegate2 = () => "world!";

			Functional functional = delegate (MyDelegate d1, MyDelegate d2) { return delegate () { return d1.Invoke() + d2.Invoke(); }; };

			Functional functional1 = (MyDelegate d1, MyDelegate d2) => () => d1() + d2();

			Console.WriteLine(functional(myDelegate1, myDelegate2).Invoke());
		}
	}
}
