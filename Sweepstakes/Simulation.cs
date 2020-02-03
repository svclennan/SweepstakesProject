using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public MarketingFirm marketingFirm;
        public Sweepstakes sweep;
        public void CreateMarketingFirm()
        {
            marketingFirm = new MarketingFirm(SweepstakesManagerFactory.CreateSweepstakesManager());
        }
        public void CreateSweepStakes()
        {
            marketingFirm.CreateSweepstakes();
        }
        public void PickWinner()
        {
            sweep = marketingFirm._manager.GetSweepstakes();
            sweep.PrintContestantInfo(sweep.PickWinner());
        }
        public void NotifyWinners()
        {
            foreach (KeyValuePair<int,Contestant> contestant in sweep.contestants)
            {
                contestant.Value.NotifyContestants();
            }
        }
        public void RunGame()
        {
            CreateMarketingFirm();
            CreateSweepStakes();
            PickWinner();
            NotifyWinners();
        }
    }
}