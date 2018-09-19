using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Generics
{
	public abstract class Shape { }
	public class Circle : Shape { }

	public interface IContainer<in T>
	{
		T Figure { set; }
	}

	public class Container<T> : IContainer<T>
	{
		private T figure;

		public T Figure
		{
			set { this.figure = value; }
		}

		public Container(T figure)
		{
			this.figure = figure;
		}

		public override string ToString()
		{
			return figure.GetType().ToString();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Shape shape = new Circle();
			IContainer<Circle> container = new Container<Shape>(shape);

			Console.WriteLine(shape.ToString());
		}
	}
}
