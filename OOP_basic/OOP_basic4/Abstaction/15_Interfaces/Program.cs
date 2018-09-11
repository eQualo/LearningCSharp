using System;


namespace _15_Interfaces
{

    interface IGoEater
    {
        void Go();
        void Eat();
    }

    interface ISecurity : IGoEater
    {
        void Guard();
    }

    class Dog : ISecurity
    {


        public void Go()
        {
            Console.WriteLine("Dog step");
        }

        public void Eat()
        {
            Console.WriteLine("Dog style eat");
        }
        public void Guard()
        {
            Console.WriteLine("Dog guard");
        }
    }

    class Cat : IGoEater
    {
        public void Go()
        {
            Console.WriteLine("Cat step");
        }

        public void Eat()
        {
            Console.WriteLine("Cat style eat");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Go();
            dog.Eat();
            dog.Guard();

            cat.Go();
            cat.Eat();
            //То есть интерфейсы взаимодействия с классами одинаковые
            //Интерфейсы классов совпадают, то есть объекты этих классов - однотипные
            //Следовательно создаем интерфейс GoEater

            ISecurity dog1 = new Dog();
            IGoEater cat1 = new Cat();

            dog1.Guard();
        }
    }
}
