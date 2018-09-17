using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //СтрингБилдер гораздо эффективнее использования простых строк, т.к.
            //он не создает новых экземплятов, а непосредственно изменяет внутренние
            //символьные данные объекта
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sbhas {0} chars.", sb.Length);
            Console.WriteLine();
        }
    }
}
