using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generics
{
	class MyClass<TYPE1, TYPE2>
	{
		private TYPE1 field1;
		private TYPE2 field2;

		public MyClass(TYPE1 field1, TYPE2 field2)
		{
			this.field1 = field1;
			this.field2 = field2;
		}

		public TYPE1 Property1
		{
			get { return this.field1; }
		}
		public TYPE2 Property2
		{
			get { return this.field2; }
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			MyClass<int, string> myClass = new MyClass<int, string>(10, "qweqwe");
			Console.WriteLine(myClass.Property1);
			Console.WriteLine(myClass.Property2);
		}
	}
}
