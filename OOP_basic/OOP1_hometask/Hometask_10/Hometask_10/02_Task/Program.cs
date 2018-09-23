using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Task
{
	public interface IMyList<T> //Интерфейсы также могут быть параметризированными
	{
		void Add(T a); //Сигнатура параметризированного метода Add
		T this[int index] { get; } //Сигнатура индексатора
		int Count { get; } //Сигнатура свойства Count
		void Clear(); //Сигнатура метода Clear
		//bool Contains(T item); //Сигнатура метода-предиката
	}

	class MyList<T> : IMyList<T>
	{
		private int count = 0;
		public int Count { get { return this.count; } }

		private T[] elements;
		//public T[] Elements { get { return this.elements; } }

		public MyList(int count)
		{
			this.elements = new T[count];
			this.count = count;
		}

		public T this[int index]
		{
			get { return this.elements[index]; }
		}

		public void Add(T value)
		{
			T[] buf = new T[this.Count + 1];
			for(int i =0; i<this.Count; i++)
			{
				buf[i] = this.elements[i];
			}
			buf[this.Count] = value;
			this.elements = buf;
			this.count++;
		}

		public void Clear()
		{
			this.elements = new T[0];
			this.count = 0;
		}

		public override string ToString()
		{
			string str = null;
			for(int i=0;i<this.Count;i++)
			{
				str += this.elements[i].ToString() + " ";
			}
			return "Массив из " + this.Count.ToString() + " элементов. Элементы массива: " + str;
		}
		//public bool Contains(T item)
		//{
		//	for(int i =0;i<this.Count;i++)
		//	{
		//		if (this.elements[i] == item)
		//			return true;
		//	}
		//}

	}
	class Program
	{
		static void Main(string[] args)
		{
			MyList<double> myList = new MyList<double>(3);
			Console.WriteLine(myList.ToString());
			myList.Add(123.12);
			myList.Add(52);
			Console.WriteLine(myList.ToString());
			myList.Clear();
			Console.WriteLine(myList.ToString());
			
		}
	}
}
