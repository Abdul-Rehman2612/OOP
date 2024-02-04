using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Task2
{
    internal class Calculator
    {
        public double num1;
        public double num2;
        public double result;
        public Calculator()
        {

        }
        public Calculator(Calculator nums) {
            num1=nums.num1;
            num2=nums.num2;
        }
        public void Add() 
        {
            result=num1+num2;
        }
        public void Subtract()
        {
            result=num1-num2;
        }
        public void Divide()
        {
            result=num1/num2;
        }
        public void Product()
        {
            result=num1*num2;
        }
    }
}
