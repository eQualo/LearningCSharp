﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Document.Parts
{
    class Title
    {
        private string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Тело заголовка отсутствует";
            }

            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
