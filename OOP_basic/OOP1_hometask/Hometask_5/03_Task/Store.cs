using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Task
{
    class Store
    {
        Article[] articles;

        public Store()
        {
            articles = new Article[3];
            articles[0].ProductName = "Картофан";
            articles[1].ProductName = "вода";
            articles[2].ProductName = "мясо";
            articles[0].ShopName = "shop1";
            articles[1].ShopName = "shop2";
            articles[2].ShopName = "shop3";
            articles[0].ProductCost = 123.12;
            articles[1].ProductCost = 234.12;
            articles[2].ProductCost = 345.12;
        }

        public string this[int index]
        {
            get
            {
                return string.Format("name = {0}, shop = {1}, cost = {2}", articles[index].ProductName, articles[index].ShopName, articles[index].ProductCost);
            }
        }
        public string this[string name]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                    if (articles[i].ProductName == name)
                        return articles[i].ShopName + " " + articles[i].ProductCost.ToString();
                return "No name!";
            }
        }
    }
}
