using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class NumberSwitcher
    {
        public static void SwitchTwoNumbers(int x, int y)
        {
            Console.WriteLine();
            Console.WriteLine($"You enterd number 1: { x } and number 2: { y }");

            var temp = x;
            x = y;
            y = temp;

            Console.WriteLine();
            Console.WriteLine("The numbers have now switched.");
            Console.WriteLine();
            Console.WriteLine($"Number 1: { x } and number 2: { y }");
        }
    }
}
