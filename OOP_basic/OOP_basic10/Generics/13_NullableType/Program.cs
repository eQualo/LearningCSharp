using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_NullableType
{
	class Program
	{
		static void Main(string[] args)
		{
			int? a = null;
			Console.WriteLine(a.GetType().Name);
			int? b = -5;
			if(a>b)
				Console.WriteLine("1");
			else
				Console.WriteLine("2");

			int? k = null;
			int? m;

			b = a ?? 10; //b=10
			Console.WriteLine(b);
			b = (a != null) ? a : 10;
			Console.WriteLine(b);
			Console.WriteLine(b.GetType().Name);

		}
	}
}
