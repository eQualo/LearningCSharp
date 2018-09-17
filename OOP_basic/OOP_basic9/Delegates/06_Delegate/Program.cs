using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Delegate
{
	public delegate int MyDelegate(int a, int b);


	class Program
	{
		static void Main(string[] args)
		{
			int summand1 = 1, summand2 = 2;
			MyDelegate myDelegate = delegate(int a, int b) { return a+b; };

			Console.WriteLine(myDelegate.Invoke(summand1, summand2));
		}
	}
}
