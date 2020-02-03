﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> Queue = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            string input = UserInterface.ChooseSpecificSweepstake();

            for (int i = 0; i < Queue.Count(); i++)
            {
                if (input.ToLower().Trim() == Queue.ElementAt(i).Name.ToLower().Trim())
                {
                    return Queue.ElementAt(i);
                }
            }
            throw new ApplicationException(" No Sweepstakes With That Name Exist!");
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Queue.Enqueue(sweepstakes);
        }

        public Sweepstakes Sweepstakes()
        {
            throw new NotImplementedException();
        }
    }

   
}
