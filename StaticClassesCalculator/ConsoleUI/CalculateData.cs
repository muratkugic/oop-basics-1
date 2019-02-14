using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class CalculateData
    {
        public static double Calculation(double x, string operand, double y)
        {
            double result = 0.0;

            switch (operand)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
            }

            return result;
        }
    }
}
