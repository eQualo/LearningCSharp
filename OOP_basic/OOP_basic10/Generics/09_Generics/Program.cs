using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generics
{
	class Animal { }
	class Cat : Animal { }


	class Program
	{
		delegate T Mydelegate<out T>();

		public static Cat CatCreator()
		{
			return new Cat();
		}
		static void Main(string[] args)
		{
			Mydelegate<Cat> delegateCat = new Mydelegate<Cat>(CatCreator);

			Mydelegate<Animal> delegateAnimal = delegateCat;

			Animal animal = delegateAnimal.Invoke();

			Console.WriteLine(animal.GetType().Name);
		}
	}
}
