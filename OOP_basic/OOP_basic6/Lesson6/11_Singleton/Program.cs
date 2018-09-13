using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Singleton
{
    class Singleton
    {
        private static Singleton instance = null;

        //Конструктор protected
        protected Singleton()
        {

        }

        //Фабричный метод
        public static Singleton Instance()
        {
            //Если объект еще не создан
            if (instance == null)
            {
                //то создаем новый экземпляр
                instance = new Singleton();
            }

            return instance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //конструктор protected - нельзя использовать new Singleton
            Singleton instance = Singleton.Instance();

            Singleton instance1 = Singleton.Instance();

            if(instance == instance1 )
                Console.WriteLine("123");

            Console.WriteLine(instance.GetHashCode());
            Console.WriteLine(instance1.GetHashCode());

        }
    }
}
