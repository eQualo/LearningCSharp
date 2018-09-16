using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			EnumType x = EnumType.Five;
			EnumType y = EnumType.One;

			if(EnumType.Five < EnumType.One)
				Console.WriteLine("1");
			else
				Console.WriteLine("2");
			if (x < y)
				Console.WriteLine("1");
			else
				Console.WriteLine("2");
		}
	}
}
