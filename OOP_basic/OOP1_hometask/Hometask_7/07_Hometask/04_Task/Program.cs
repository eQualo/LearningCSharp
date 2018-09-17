using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Task
{
	struct Notebook
	{
		private string model;
		private string company;
		private double price;

		public string Model { get { return this.model; } }
		public string Company { get { return this.company; } }
		public double Price { get { return this.price; } }

		public Notebook(string model, string company, double price)
		{
			this.price = price;
			this.model = model;
			this.company = company;
		}

		public void Show()
		{
			Console.WriteLine("Model {0}, Company {1}, Price {2}", this.Model, this.Company, this.Price);
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Notebook notebook = new Notebook("ASUS", "123", 124512.123);

			notebook.Show();
		}
	}
}
