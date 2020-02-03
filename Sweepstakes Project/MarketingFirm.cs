using System;

namespace Sweepstakes_Project
{
    internal class MarketingFirm
    {
        private ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        internal void FirmMenu()
        {
            throw new NotImplementedException();
        }
    }
}