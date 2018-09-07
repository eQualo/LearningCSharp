using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Task
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CalcPrice(bool ifNDS)
        {
            double cost;
            switch (this.Article.ToLower())
            {
                case "chair":
                    cost = 1400;
                    break;
                case "table":
                    cost = 3000;
                    break;
                case "bed":
                    cost = 5000;
                    break;
                default:
                    Console.WriteLine("No information about: " + this.Article);
                    return;
            }

            if (ifNDS)
                cost *= 1.18;

            Console.WriteLine("Sum = {0}", cost * this.Quantity);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(1, "Kirill", "HHHHome");

            inv.Article = "ChAIr";
            inv.Quantity = 4;

            inv.CalcPrice(true);
            inv.CalcPrice(false);

            Console.ReadKey();
        }
    }
}
