using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class UserInterface
    {
        public static string GetContestantFirstName()
        {
            Console.WriteLine("Contenstant's first name");
            string firstNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return firstNameInput;
        }

        public static string GetContestantLastName()
        {
            Console.WriteLine("Contenstant's last name");
            string lastNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return lastNameInput;
        }

        public static string GetContestantEmail()
        {
            Console.WriteLine("Contenstant's email");
            string emailInput = Console.ReadLine();
            Console.WriteLine(" ");

            return emailInput;
        }
}
