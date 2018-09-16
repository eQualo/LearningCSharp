using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			Array array = Enum.GetValues(typeof(EnumType));

			Console.WriteLine("Length: {0}", array.Length);


			for(int i = 0; i<array.Length;i++)
			{
				Console.WriteLine("Name of {0} element is: {1}, value {1:D}", i, array.GetValue(i));
			}
		}
	}
}
