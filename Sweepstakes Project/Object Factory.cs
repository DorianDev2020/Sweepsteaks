using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    public class Object_Factory
    {

        public ISweepstakesManager SetManagment()
        {
            string input = UserInterface.ChooseManagmentTool();
            switch (input.ToLower().Trim())
            {
                case "Q":
                    return new SweepstakesQueueManager();
                case "S":
                    return new SweepstakesStackManager();
                default:
                    throw new ApplicationException("Input Was Not A Valid Sweepstakes Managment Tool.");
                    
            }
        }
    }
}
