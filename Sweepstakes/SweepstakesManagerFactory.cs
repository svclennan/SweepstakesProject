using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class SweepstakesManagerFactory
    {
        public static ISweepstakesManager CreateSweepstakesManager()
        {
            string DataStructureType = UserInterface<string>.GetUserInputFor("Would you like to store your sweeptsakes as a queue or stack?");
            switch (DataStructureType)
            {
                case ("queue"):
                    {
                        return new SweepstakesQueueManager();
                    }
                case ("stack"):
                    {
                        return new SweepstakesStackManager();
                    }
                default:
                    {
                        return CreateSweepstakesManager();
                    }
            }
        }
    }
}