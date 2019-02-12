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
            UserMessages.WelcomeMessage();

            int num1 = RequestData.GetUserNumber("Enter your first whole number: ");
            int num2 = RequestData.GetUserNumber("Enter your second whole number: ");

            NumberSwitcher.SwitchTwoNumbers(num1, num2);

            UserMessages.GoodByeMessage();



            Console.ReadLine();
        }
    }
}
