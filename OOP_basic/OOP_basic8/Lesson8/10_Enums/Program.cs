using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			EnumType digit = EnumType.Ten; 

			Type @enum = digit.GetType(); //содержит информацию об энамтайп


			//GetUnderlyingType(@enum) показывает тип для констант перечисления
			Console.WriteLine("Перечислние {0} состоит из элементов типа", @enum.Name);
			Type @const = Enum.GetUnderlyingType(@enum);
			Console.WriteLine(@const);

			//Оператор typeof - возвращае экз класса syystem.type, который содержит информацию о том типа, которы был мпередан в кач-ве пргумента данного оператора

			Console.WriteLine(Enum.GetUnderlyingType(typeof(EnumType)));
		}
	}
}
