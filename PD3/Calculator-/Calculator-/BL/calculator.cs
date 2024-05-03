using System;

namespace CalculatorApp.BL
{
    public class Calculator
    {
        public double Number1;
        public double Number2;

        public Calculator(double number1 = 10, double number2 = 10)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public void SetValues(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public double Add()
        {
            return Number1 + Number2;
        }

        public double Subtract()
        {
            return Number1 - Number2;
        }

        public double Multiply()
        {
            return Number1 * Number2;
        }

        public string Divide()
        {
            try
            {
                double result = Number1 / Number2;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Error: Division by zero";
            }
        }

        public string Modulo()
        {
            try
            {
                double result = Number1 % Number2;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Error: Modulo by zero";
            }
        }
    }
}
