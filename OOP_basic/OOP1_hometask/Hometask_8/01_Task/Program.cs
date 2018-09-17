using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Task
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			DateTime birthday = Convert.ToDateTime(Console.ReadLine());
			TimeSpan timeLeft = birthday - now;
			Console.WriteLine("{0} days left", timeLeft.Days);
		}
	}
}
