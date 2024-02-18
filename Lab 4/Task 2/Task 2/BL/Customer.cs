using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.BL
{
    internal class Customer
    {
        public string Name;
        public string Address;
        public string Contact;
        public List<Products> products = new List<Products>();
        public Customer(string name, string address, string contact)
        {
            this.Name=name;
            this.Address=address;
            this.Contact=contact;
        }
        public void addProducts(Products product)
        {
            products.Add(product);
        }
    }
}
