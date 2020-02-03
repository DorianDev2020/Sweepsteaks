using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UI
    {
        public static string GetContestantFirstName()
        {
            Console.WriteLine("Enter First Name");
            string InputfirstName = Console.ReadLine();
            Console.WriteLine("");

            return InputfirstName;
        }

        public static string GetContestantLastName()
        {
            Console.WriteLine("Enter Last Name");
            string InputlastName = Console.ReadLine();
            Console.WriteLine("");

            return InputlastName;
        }

        public static string GetContestantEmailAddress()
        {
            Console.WriteLine("Enter Email Address");
            string inputEmailAddress = Console.ReadLine();
            Console.WriteLine("");

            return inputEmailAddress;
        }

        //public static int GetContestantRegistrationNum() {}
       
    }
}
