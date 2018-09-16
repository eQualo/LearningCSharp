using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Boxing
{
	class Program
	{
		static void Main(string[] args)
		{
			short a = 25;

			//boxing
			object o = a;

			//unboxing
			short b = (short)o;

			//int i = (int)o; НЕЛЬЗЯ

		}
	}
}
