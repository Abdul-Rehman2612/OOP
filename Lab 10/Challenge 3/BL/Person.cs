using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        protected string name;
        protected string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return name;
        }
        public string getaddress()
        {
            return address;
        }
        public void setaddress(string address)
        {
            this.address = address;
        }

        public string tostring()
        {
            return $"Person [name = {name},address = {address}]";
        }
    }
}
