﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Delegate
{
	public delegate void MyDelegate();
	class Program
	{
		static void Main(string[] args)
		{
			MyDelegate myDelegate = delegate { Console.WriteLine("Hello"); };

			myDelegate();
		}
	}
}
