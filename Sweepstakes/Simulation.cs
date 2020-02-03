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
        public void CreateMarketingFirm()
        {
            marketingFirm = new MarketingFirm(SweepstakesManagerFactory.CreateSweepstakesManager());
        }
        public void CreateSweepStakes()
        {
            marketingFirm.CreateSweepstakes();
        }
        public string PickWinner()
        {
            return marketingFirm._manager.GetSweepstakes().PickWinner().ToString();
        }
        public void RunGame()
        {
            CreateMarketingFirm();
            CreateSweepStakes();
            UserInterface<string>.Print(PickWinner() + " won.");
        }
    }
}