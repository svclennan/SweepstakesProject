using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.CreateMarketingFirm();
            Sweepstakes ss = new Sweepstakes("Million Dollar Car");
            ss.RegisterContestant(new Contestant("Sean", "Clennan", "emailAddress@gmail.com", 1234));
            simulation.marketingFirm._manager.InsertSweepstakes(ss);
            Sweepstakes sweep = simulation.marketingFirm._manager.GetSweepstakes();
            Console.WriteLine(sweep.PickWinner());
            Console.ReadLine();
        }
    }
}
