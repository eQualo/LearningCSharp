using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DateTime
{
	class Program
	{
		static void Main(string[] args)
		{
			// DateTime.Now возвращает объект System.DateTime, которому присвоены текущие дата и время
			// суток данного компьютера
			DateTime now = DateTime.Now;

			Console.WriteLine("Текущая дата и время : {0}", now);
			Console.WriteLine("Год: {0}", now.Year);
			Console.WriteLine("Месяц: {0}", now.Month);
			Console.WriteLine("День месяца: {0}", now.Day);

			Console.WriteLine("Текущее время - {0}:{1}:{2}", now.Hour, now.Minute, now.Second);

			Console.WriteLine("День недели : {0}", now.DayOfWeek);
			Console.WriteLine("Это {0}-й день года", now.DayOfYear);

			//Получаем дату текущего компьютера и значение времени, равное полуночи (00:00:00).
			Console.WriteLine(DateTime.Now.Date);
		}
	}
}
