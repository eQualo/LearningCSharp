using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Вудупфеу
{
	delegate R MyDelegate<T, R>(T t);
	class Program
	{
		public static int Add(int i)
		{
			return ++i;
		}

		public static string Concat(string s)
		{
			return "Hello " + s + "!"; 
		}

		static void Main(string[] args)
		{
			MyDelegate<int, int> myDelegate = new MyDelegate<int, int>(Add);
			int i = myDelegate(1);
			Console.WriteLine(i);

			MyDelegate<string, string> my = new MyDelegate<string, string>(Concat);
			Console.WriteLine(my.Invoke("Leks"));
		}
	}
}
