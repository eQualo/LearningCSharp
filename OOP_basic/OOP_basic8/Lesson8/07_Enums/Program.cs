using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Enums
{
	enum EnumType : byte
	{
		Zero = 0,
		One = 1,
		Two = 2,
		Three = 3
	}
	class Program
	{
		static void Main(string[] args)
		{
			Enum one = EnumType.One;
			Console.WriteLine(one);
			EnumType digit = EnumType.Zero;
			Enum zero = digit;
			Console.WriteLine(zero);

			Console.WriteLine(new string('-', 30));

			for(EnumType number = EnumType.Zero; number<=EnumType.Three; number++)
			{
				Console.WriteLine(number);
			}

		}
	}
}
