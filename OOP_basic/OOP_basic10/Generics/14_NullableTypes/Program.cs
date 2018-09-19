using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NullableTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			Nullable<int> a = 1;
			if(a.HasValue)
				Console.WriteLine("123");
		}
	}
}
