using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Covariant
{
    public interface IAnimal
    {
        void Voice();
    }

    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog()};

            for(int i = 0; i<dogs.Length; i++)
            {
                dogs[i].Jump();
                dogs[i].Voice();
            }

            Console.WriteLine(new string('-', 20));

            IAnimal[] animals = dogs; //Ковариантность
            for (int i = 0; i<animals.Length; i++)
            {
                animals[i].Voice();
                //animals[i].Jump(); нельзя

            }

            Console.WriteLine(new string('-', 20));

            dogs = (Dog[])animals; //не является контрвариантностью

            dogs[0].Voice();
            dogs[1].Jump();
        }
    }
}
