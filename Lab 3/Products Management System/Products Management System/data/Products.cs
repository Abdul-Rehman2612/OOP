using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Management_System.data
{
    internal class Products
    {
        public string ID;
        public string Name;
        public string Category;
        public string BrandName;
        public double Price;
        public string Country;
        public Products(string id,string name,string category,string brand,double price,string country)
        { 
            this.ID = id;
            this.Name = name;
            this.Category = category;
            this.BrandName = brand;
            this.Price = price;
            this.Country = country;
        }
        public double CalculateProductsWorth(List<Products> products)
        {
            double totalWorth = 0.0;
            for (int i = 0; i<products.Count; i++)
            {
                totalWorth+=products[i].Price;
            }

            return totalWorth;
        }
    }
}
