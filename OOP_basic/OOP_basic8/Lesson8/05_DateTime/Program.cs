using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DateTime
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime newYear = new DateTime(2019, 1, 1);

			DateTime today = DateTime.Now;

			TimeSpan left = newYear - today;

			Console.WriteLine("{0} days left", left.Days);
			while(true)
			{
				if(today.Second != DateTime.Now.Second)
				{
					Console.WriteLine(today);
					today = DateTime.Now;
				}
			}
			
		}
	}
}
