using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface<string>.GetUserInputFor("What is the name of this sweepstake?"));
            _manager.InsertSweepstakes(sweepstakes);
        }
    }
}
