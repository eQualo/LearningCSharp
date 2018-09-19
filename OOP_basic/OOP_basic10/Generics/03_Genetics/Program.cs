using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Genetics
{
	class Program
	{
		public void Method<T>(T arg)
		{
			T variable = arg;
			Console.WriteLine(variable);
		}
		static void Main(string[] args)
		{
			Program program = new Program();
			program.Method<string>("123123");

			program.Method("312312");
		}
	}
}
