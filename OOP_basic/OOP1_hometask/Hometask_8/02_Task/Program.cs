using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Task
{
	enum MyEnum
	{
		Red,
		Blue,
		Black,
		Green
	}

	static class MyClass
	{
		public static void Print(string str, int color)
		{
			switch (color)
			{
				case (int)MyEnum.Red:
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(str);
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
				case (int)MyEnum.Green:
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(str);
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
				case (int)MyEnum.Blue:
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine(str);
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
				case (int)MyEnum.Black:
					Console.ForegroundColor = ConsoleColor.Black;
					Console.WriteLine(str);
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input one of these colors");
			for(MyEnum number = MyEnum.Red; number<=MyEnum.Green; number++)
			{
				Console.Write("{0} = {0:D}   ", number);
			}
			Console.WriteLine();
			int color = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input string");
			string str = Console.ReadLine();

			MyClass.Print(str, color);
		}
	}
}
