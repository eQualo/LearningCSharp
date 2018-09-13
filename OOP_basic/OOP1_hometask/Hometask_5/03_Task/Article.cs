using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Task
{
    class Article
    {
        string productName;
        string shopName;
        double productCost;

        public string ProductName { get { return productName; } set { productName = value; } }
        public string ShopName { get { return shopName; } set { shopName = value; } }
        public double ProductCost { get { return productCost; } set { productCost = value; } }
    }
}
