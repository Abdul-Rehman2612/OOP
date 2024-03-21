using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        private string program;
        
        private int year;
        private double fee;

        public Student(string Program, int year, double fee, string name, string address):base(name,address)
        {
            this.program = Program;
            this.year = year;
            this.fee = fee;
        }

        public string getprogram()
        {
            return program;
        }
        public int getyear()
        {
            return year;
        }
        public double getfee()
        {
            return fee;
        }
        public void setprogram(string program)
        {
            this.program = program;
        }
        public void setyear(int year)
        {
            this.year=year;
        }
        public void setfee(double fee)
        {
            this.fee = fee;
        }
    }
}
