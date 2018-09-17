using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Task
{
	public delegate void MyDelegate();
	class Program
	{
		public static void Method1()
		{
			Console.WriteLine("1");
		}

		public static void Method2()
		{
			Console.WriteLine("2");
		}

		public static void Method3()
		{
			Console.WriteLine("3");
		}

		static void Main(string[] args)
		{
			MyDelegate myDelegate = null;
			MyDelegate myDelegate1 = new MyDelegate(Method1);
			MyDelegate myDelegate2 = new MyDelegate(Method2);
			MyDelegate myDelegate3 = new MyDelegate(Method3);

			myDelegate = myDelegate1 + myDelegate2 + myDelegate3;


			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					myDelegate1();
					break;
				case "2":
					myDelegate2();
					break;
				case "3":
					myDelegate3();
					break;
				case "4":
					MyDelegate myDelegate4 = myDelegate - myDelegate1;
					myDelegate4();
					break;
				case "5":
					MyDelegate myDelegate5 = myDelegate - myDelegate2;
					myDelegate5();
					break;
				case "6":
					MyDelegate myDelegate6 = myDelegate - myDelegate3;
					myDelegate6();
					break;
				case "7":
					myDelegate();
					break;
			}
		}
	}
}
