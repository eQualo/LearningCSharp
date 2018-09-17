using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
	class MyClass
	{
		public string Method(string name)
		{
			return "Hello " + name;
		}
	}

	public delegate string MyDelegate(string name);
	class Program
	{
		static void Main(string[] args)
		{
			MyClass myClass = new MyClass();

			MyDelegate myDelegate = new MyDelegate(myClass.Method);

			string a = myDelegate.Invoke("123123");
			Console.WriteLine(a);

			a = myDelegate("35235");
			Console.WriteLine(a);
		}
	}
}
