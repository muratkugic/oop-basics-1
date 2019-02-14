using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple calculator.
            // The focus of this program is to show I understand the basics of using
            // static classes.

            UserMessages.WelcomeMessage();

            double num1 = RequestData.GetADouble("Enter your first number: ");
            string operand = RequestData.GetAString("Enter operand you would like to use: ");
            double num2 = RequestData.GetADouble("Enter your second number: ");

            var result = CalculateData.Calculation(num1, operand, num2);

            UserMessages.PrintResultMessage($"Result of { num1 } { operand } { num2 } = { result }");
            
            UserMessages.GoodByeMessage();

            Console.ReadLine();
        }
    }
}
