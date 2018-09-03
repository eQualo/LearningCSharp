using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2
{
    class Point
    {
        //fields
        private int x, y;
        private string name;

        //properties
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        //Constructor (default). Initialize default values
        public Point()
        {
            Console.WriteLine("Default construcror!");
        }

        //User constructor. Initialize fields with another values
        //Использование ключевого слова this в конструкторе с одним параметром с 49-й строки
        //приводит к вызову этого конструктора
        public Point(int x, int y)
        {
            Console.WriteLine("Конструктор с двумя параметрами!");
            this.x = x;
            this.y = y;
        }

        //Использование ключевого слова this в конструкторе приводит к вызову конструктора с двумя параметрами с 40-й строки
        //приводит к вызову этого конструктора
        public Point(string name)
            : this(300, 400)
        {
            Console.WriteLine("Конструктор с одним параметром!");
            this.name = name;
        }
    }
}
