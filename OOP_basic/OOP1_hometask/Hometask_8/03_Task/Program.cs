using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Task
{
	enum Post
	{
		worker = 20,
		manager = 40,
		developer = 40,
		director = 50
	}

	static class Accountant
	{
		static public bool AskForBonus(Post post, int hours)
		{
			return (hours > (int)post);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Accountant.AskForBonus(Post.developer, 30));
			Console.WriteLine(Accountant.AskForBonus(Post.worker, 30));	
		}
	}
}
