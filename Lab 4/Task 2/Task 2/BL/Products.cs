using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.BL
{
    internal class Products
    {
        public string name;
        public string category;
        public double price;
        public double tax;
        public Products(string Pname,string Pcategory,double Pprice) 
        {
            this.name = Pname;
            this.category = Pcategory;
            this.price = Pprice;
            this.tax=calculateTax();
        }
        public double calculateTax()
        {
            return 0.1*price;
        }
    }
}
