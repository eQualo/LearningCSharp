using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Generics
{
	class Animal { }
	class Cat : Animal { }

	class Program
	{
		delegate void MyDelegate<in T>(T a);


		public static void CatUser(Animal animal)
		{
			Console.WriteLine(animal.GetType().Name);
		}
		static void Main(string[] args)
		{
			MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(CatUser);

			MyDelegate<Cat> delegateCat = delegateAnimal;

			delegateAnimal(new Animal());
			delegateCat(new Cat());

		}
	}
}
