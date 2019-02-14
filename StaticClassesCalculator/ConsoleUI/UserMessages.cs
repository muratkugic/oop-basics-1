using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class UserMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to a basic calculator using static classes.");
            Console.WriteLine();
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }

        public static void GoodByeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for using this app and make sure to tell your firends! ;)");
        }
    }
}
