﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Enums
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
		static void Main()
		{
			// Переменной five типа EnumType может быть назначено любое значение, входящее в диапазон
			// базового типа, значения не ограничены именованными константами.

			EnumType five = (EnumType)5;

			Console.WriteLine(five);

			// Delay.
			Console.ReadKey();
		}
	}
}

