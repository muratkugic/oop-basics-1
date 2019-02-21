using LibraryDemo;
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
            PersonModel person = new PersonModel();

            string firstName = GetName.GetAName("Enter your name: ");
            string lastName = GetName.GetAName("Enter your last name: ");

            person.FirstName = firstName;
            person.LastName = lastName;

            DisplayName.DisplayAName(firstName, lastName);


            Console.ReadLine();
        }
    }
}
