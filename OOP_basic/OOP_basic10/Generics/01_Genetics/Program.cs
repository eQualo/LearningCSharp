using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Genetics
{
	class MyClass<T>
	{
		public T field;
		public void Method()
		{
			Console.WriteLine(field.GetType());
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			MyClass<int> instance1 = new MyClass<int>();
			instance1.Method();

			MyClass<long> instance2 = new MyClass<long>();
			instance2.Method();

			MyClass<string> inst = new MyClass<string>();
			inst.field = "asd";
			inst.Method();
		}
	}
}
