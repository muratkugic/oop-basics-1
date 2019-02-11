using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the static class demo app.");

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good Morning { firstName }");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon { firstName }");
            }
            else
            {
                Console.WriteLine($"Good Evening { firstName }");
            }
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using this simple addition app.");
        }
    }
}
