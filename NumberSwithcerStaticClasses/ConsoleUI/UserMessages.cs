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
            Console.WriteLine("Welcome to the number switcher app.");
            Console.WriteLine("Enter two numbers and the app will change their place.");
            Console.WriteLine();
        }

        public static void GoodByeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for using the awsome number switcher app! :)");
        }
    }
}
