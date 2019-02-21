using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class GetName
    {
        public static string GetAName(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
    }
}
