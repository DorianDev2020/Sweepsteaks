using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Object_Factory obj = new Object_Factory();
            ISweepstakesManager manager = obj.SetManagment();
            MarketingFirm marketing = new MarketingFirm(manager);
            marketing.FirmMenu();
            Sweepstakes sweep = new Sweepstakes();
            sweep.SweepstakesMenu();
            Console.ReadLine();
        }
    }
}
