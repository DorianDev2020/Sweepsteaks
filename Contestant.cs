using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //Member Variables;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int RegistrationNumber;

        public string Firstname {get => firstName; set => firstName = value;}
        public string Lastname { get => lastName; set => lastName = value;}

        public string Emailaddress { get => emailAddress; set => emailAddress = value;}

        //public int Not Sure How To Go About Entering A Contestant Registration Number.

        public  Contestant ContestantInformation()
        {
            var contestant = new Contestant();
            contestant.firstName = UI.GetContestantFirstName();
            contestant.lastName = UI.GetContestantLastName();
            contestant.emailAddress = UI.GetContestantEmailAddress();
            return contestant;
        }

    }
   
}
