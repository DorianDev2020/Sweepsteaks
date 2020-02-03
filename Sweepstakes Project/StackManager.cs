using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            string input = UserInterface.ChooseSpecificSweepstake();
            for (int i = 0; i < stack.Count(); i++)
            {
                if (input.ToLower().Trim()== stack.ElementAt(i).Name.ToLower().Trim())
                {
                    return stack.ElementAt(i);
                }
            }
            throw new ApplicationException("No Sweepstakes With That Name Exist");
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes Sweepstakes()
        {
            throw new NotImplementedException();
        }
    }
    

    
}
