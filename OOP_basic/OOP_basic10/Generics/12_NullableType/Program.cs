using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_NullableType
{
	class Program
	{
		static void Main(string[] args)
		{
			//a - содержит неизвестное значение
			int? a = null;
			int? b = a * 3;

			int? c;

			if(b==null)
				Console.WriteLine("123123");
			Console.WriteLine("->{0}<-", a);
		}
	}
}
