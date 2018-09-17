using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Delegate
{
	public delegate int MyDelegate(int a);
	class Program
	{
		static void Main(string[] args)
		{
			MyDelegate myDelegate;

			myDelegate = delegate (int x) { return x * 2; };

			myDelegate = (x) => { return x * 2; };

			myDelegate = (x) => x * 2;

			int result = myDelegate(4);
			Console.WriteLine(result);
		}
	}
}
