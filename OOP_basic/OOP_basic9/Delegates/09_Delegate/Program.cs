using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Delegate
{
	public delegate void MyDelegate();
	class Program
	{
		
		static void Main(string[] args)
		{
			MyDelegate myDelegate;

			myDelegate = delegate () { Console.WriteLine("Hello "); };

			myDelegate += () => { Console.WriteLine("it`s "); };

			myDelegate += () => Console.WriteLine("me");

			myDelegate.Invoke();
		}
	}
}
