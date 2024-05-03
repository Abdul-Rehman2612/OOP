using System;


namespace CalculatorApp.BL
{
    internal  class Calculator
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

        public double Sqrt(double number)
        {
            return Math.Sqrt(number);
        }

        public double Exp(double exponent)
        {
            return Math.Exp(exponent);
        }

        public double Log(double number)
        {
            return Math.Log(number);
        }

        public double Sin(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            return Math.Sin(angleInRadians);
        }

        public double Cos(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            return Math.Cos(angleInRadians);
        }

        public double Tan(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            return Math.Tan(angleInRadians);
        }
    }
}

