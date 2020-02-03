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
        public static string SweepstakeMenuOptions()
        {
            Console.WriteLine("Press [1] to Register a Contestant.");
            Console.WriteLine("Press [2] to Retrieve a Specific Contestant's Info.");
            Console.WriteLine("Press [3] to Display All Contestants Registered.");
            Console.WriteLine("Press [4] to Start The Sweepstakes.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static string CreateSweepstakes()
        {
            Console.WriteLine("What Is The Name Of The Sweepstake?");
            string sweepstake = Console.ReadLine();
            Console.Clear();
            return sweepstake;
        }

        public static string ChooseManagmentTool()
        {
            Console.WriteLine(" Welcome To The Sweepstakes Application Manager.");
            Console.WriteLine(" Select The Sweepstakes Mangment You'd Perfer To Use.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Input [Q] for a Queue Manger.");
            Console.WriteLine("");
            Console.WriteLine(" Or");
            Console.WriteLine("");
            Console.WriteLine(" Input [S] for a Stack Manager.");
            Console.WriteLine("");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static void SweepstakesGoToCreator()
        {
            Console.WriteLine("Now that we have a sweepstake manager lets create some sweepstakes!");
            Console.WriteLine("Press [ENTER] to start creating your sweepstakes!");
            Console.ReadLine();
            Console.Clear();
        }

        public static string MakeMoreSweepstakes()
        {
            Console.WriteLine("'Sweepstake Has Been Succesfully Added!'");
            Console.WriteLine("");
            Console.WriteLine("Do You Want To Make Another Sweepstake?");
            Console.WriteLine("");
            Console.WriteLine("Input [Y] for yes.");
            Console.WriteLine("");
            Console.WriteLine("Or");
            Console.WriteLine("");
            Console.WriteLine("Input [N] for no.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static void GoToSweepstakesMenu()
        {
            Console.WriteLine(" Add Contestants,");
            Console.WriteLine("Its Not A Sweepstake Without Any Contestants!");
            Console.WriteLine("Press [ENTER] To Continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static string AddMoreContestants()
        {
            Console.WriteLine("'Contestant Was Added Successfully!'");
            Console.WriteLine("");
            Console.WriteLine(" Add Another Contestant?");
            Console.WriteLine("");
            Console.WriteLine("Input [Y] for yes.");
            Console.WriteLine("");
            Console.WriteLine("Or");
            Console.WriteLine("");
            Console.WriteLine("Input [N] for no.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static string ChooseSpecificSweepstake()
        {
            Console.WriteLine("What Sweepstake Would You Like To Use?");
            string input = Console.ReadLine();
            return input;
        }
    }
}
