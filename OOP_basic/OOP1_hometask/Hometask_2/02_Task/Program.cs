using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Task
{
    class Employee
    {
        string name;
        string surname;
        int position;       //должность
        double salary;       //оклад
        float experience;   //опыт
        double taxes;

        string Name { get { return this.name; } }
        string Surname { get { return this.surname; } }
        int Position { get { return this.position; } }
        double Salary { get { return this.salary; } }
        double Taxes { get { return this.taxes; } }

        void CalcSalary()
        {
            this.salary = this.position * 10 + this.experience;
        }

        void CalcTaxes()
        {
            this.taxes = this.salary * 0.13;
        }



        public Employee(string name, string surname, int position, float experience)
        {
            this.name = name;
            this.surname = surname;
            this.position = position;
            this.experience = experience;
            this.CalcSalary();
        }


        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Surname: {0}", this.Surname);
            Console.WriteLine("Position: {0}", this.Position);
            Console.WriteLine("Salary: {0}", this.Salary);
            Console.WriteLine("Taxes: {0}", this.Taxes);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Aleksey", "Lukyanov", 3, 1);

            emp.ShowInfo();

            Console.ReadKey();
        }
    }
}
