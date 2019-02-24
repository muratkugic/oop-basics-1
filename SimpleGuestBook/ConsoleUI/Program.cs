using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Capture the information about each guest
// Info to capture: first name, last name, message to the host
// Once done, loop though each guest and print their info

namespace ConsoleUI
{
    class Program
    {
        public static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInfo();
            
            DisplayGuestBook();
            
            Console.ReadLine();
        }

        private static void GetGuestInfo()
        {
            string addMoreGuests = "";

            do
            {
                GuestModel guest = new GuestModel
                {
                    FirstName = GetInfoFromConsole("Enter your first name: "),
                    LastName = GetInfoFromConsole("Enter your last name: "),
                    MessageToHost = GetInfoFromConsole("Enter your message: ")
                };

                addMoreGuests = GetInfoFromConsole("Press 'y' to add another guest, else press 'n': ");

                guests.Add(guest);

                Console.Clear();
            } while (addMoreGuests == "y");
        }

        private static void DisplayGuestBook()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.DisplayInfo);
            }
        }

        private static string GetInfoFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
    }
}
