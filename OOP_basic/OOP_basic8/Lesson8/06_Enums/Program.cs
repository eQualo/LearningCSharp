using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Enums
{
	//struct MyStruct
	//{
	//	public const byte zero;
	//	public const byte one;
	//	public const byte two;
	//	public const byte three;
	//}

	//struct MyStruct : byte
	//{
	//	public const  zero;
	//	public const  one;
	//	public const  two;
	//	public const  three;
	//}


		 

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
			Console.WriteLine(EnumType.Zero);
			Console.WriteLine((byte)EnumType.Zero);

			EnumType digit = EnumType.Three;
			Console.WriteLine(digit);
			Console.WriteLine((int)digit);
		}
	}
}
