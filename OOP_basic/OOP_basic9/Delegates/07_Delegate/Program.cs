using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Delegate
{
	public delegate void MyDelegate(ref int a, ref int b, out int c);
	class Program
	{
		static void Main(string[] args)
		{
			int s1 = 1, s2 = 2, sum;
			MyDelegate myDelegate = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b; };

			myDelegate.Invoke(ref s1, ref s2, out sum);

			Console.WriteLine(s1);
			Console.WriteLine(s2);
			Console.WriteLine(sum);
		}
	}
}
