﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Document.Parts;

//Это плохая реализация класса документ
//Необходимо инкапсулировать реализацию классов тайтл, боди и футер внутри класса документ
namespace _06_Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тело контракта...";

            Footer footer = new Footer();
            footer.Content = "Директор: Иванов И.И.";

            Document document = new Document(title, body, footer);
            document.Show();

            Console.ReadKey();
        }
    }
}
