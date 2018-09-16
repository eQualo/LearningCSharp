using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			//Находим элемент перечисления по имени. Тут присутствует боксинг
			object element = Enum.Parse(typeof(EnumType), "Infinite");
			//анбоксинг
			EnumType number = (EnumType)element;

			Console.WriteLine("Значение константы {0}: {1}", number, (byte)number);

			//Enum.IsDefined() - является ли строка элементом перечисления
			bool flag = Enum.IsDefined(typeof(EnumType), "one");

			Console.WriteLine(flag);
		}
	}
}
