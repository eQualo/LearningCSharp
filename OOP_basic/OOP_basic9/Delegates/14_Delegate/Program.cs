using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Delegate
{
	delegate void MyDelegate(int argument);
	class Program
	{
		static void Main(string[] args)
		{
			MyDelegate my = null;

			my = (int i) =>
			{
				i--;
				Console.WriteLine("i = {0}", i);
				if (i > 0)
					my.Invoke(i);
				Console.WriteLine("end i = {0}", i);
			};
			my(3);
		}
	}
}
