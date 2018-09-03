using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    
    class Program
    {
        public class Author
        {
            public string Name { get; set; }
            public string Book { get; set; }
        }
        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                Name = "Jeffrey Richter",   //блок инициазатора
                Book = "CLR via C#"
            };

            Author author2 = new Author     //при использовании конструктора по умолчанию можно опустить аргументные скобки
            {
                Name = "Steve McConnell",   //initialization section
                Book = "Code Complete"
            };


            Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

            Console.ReadKey();
        }
    }
}
