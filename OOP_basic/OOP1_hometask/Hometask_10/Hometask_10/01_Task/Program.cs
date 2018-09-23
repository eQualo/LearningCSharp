using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Task
{
	class MyClass<T> where T : new ()
	{
		public static T FactoryMethod()
		{
			return new T();
		}
	}
	class MyClass1
	{
		public static MyClass<MyClass1> Method()
		{
			return new MyClass<MyClass1>();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			MyClass<int>.FactoryMethod();
			int k = MyClass<int>.FactoryMethod();
			Console.WriteLine(k.GetType().Name);

			MyClass1 my = MyClass<MyClass1>.FactoryMethod();
			MyClass1.Method();
		}
	}
}
