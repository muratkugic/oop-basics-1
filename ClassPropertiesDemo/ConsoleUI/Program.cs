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
            LocationData location = new LocationData("123 Main", "San Diego", "California", "GT-32523");

            Console.WriteLine(location.FullAddress);
            

            Console.ReadLine();
        }
    }
}
