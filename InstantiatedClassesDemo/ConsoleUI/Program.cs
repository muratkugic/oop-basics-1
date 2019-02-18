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
            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";

            do
            {
                Console.Write("What is your first name or type 'q' to quit: ");
                firstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "q")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "q");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

            Console.ReadLine();
        }
    }
}
