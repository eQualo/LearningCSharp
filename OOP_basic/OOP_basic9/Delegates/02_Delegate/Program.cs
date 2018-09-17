using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegate
{
	class MyClass
	{
		public void Method()
		{
			Console.WriteLine("Method");
		}
	}

	public delegate void MyDelegate();

	class Program
	{
		static void Main(string[] args)
		{
			MyClass myClass = new MyClass();

			MyDelegate myDelegate = new MyDelegate(myClass.Method);

			myDelegate.Invoke();
			myClass.Method();

		}
	}
}
