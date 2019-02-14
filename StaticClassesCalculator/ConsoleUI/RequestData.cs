using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class RequestData
    {
        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numText = Console.ReadLine();
            double output;

            bool isValidNumber = double.TryParse(numText, out output);

            // Not using the '!' operator just to make it more readable/clear to myslef since I am learning.
            while (isValidNumber == false)
            {
                Console.Clear();
                Console.WriteLine("Not a valid number, please try again.");
                Console.Write(message);
                numText = Console.ReadLine();

                isValidNumber = double.TryParse(numText, out output);
            }

            return output;
        }

        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            while (output != "+" && output != "-" && output != "*" && output != "/")
            {
                Console.Clear();
                Console.WriteLine("Invalid operand, please try again using +, -, *, /.");
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }
    }
}
