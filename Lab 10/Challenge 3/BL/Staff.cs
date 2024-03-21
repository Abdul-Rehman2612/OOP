using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Staff: Person
    {
        protected string School;
        protected double Pay;
        public Staff(string school, double pay, string name, string address) : base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public double GetPay()
        {
            return Pay;
        }
        public string GetSchool()
        {
            return School;
        }
        public void SetPay(double pay)
        {
            this.Pay = pay;
        }
        public void SetSchool(string school)
        {
            this.School = school;
        }
    }
}
