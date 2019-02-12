using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class RequestData
    {
        public static int GetUserNumber(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            int output;

            bool isValidNumber = int.TryParse(numberText, out output);

            while (!isValidNumber)
            {
                Console.Clear();
                Console.WriteLine("Not a valid number, please try again!");
                Console.WriteLine();
                Console.Write(message);
                numberText = Console.ReadLine();

                isValidNumber = int.TryParse(numberText, out output);
            }

            return output;
        }
    }
}
