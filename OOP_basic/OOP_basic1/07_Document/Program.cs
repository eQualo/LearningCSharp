﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Контракт");
            document.Body = "Тело контракта...";
            document.Footer = "Директор: Иванов И.И.";

            document.Show();

            Console.ReadKey();
        }
    }
}
