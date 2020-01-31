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
            int numberOfContestants = Convert.ToInt32(UserInterface<int>.GetUserInputFor($"How many contestants in {sweepstakes.Name}?"));
            for (int i = 0; i < numberOfContestants; i++)
            {
                string firstName = UserInterface<string>.GetUserInputFor($"What is the {sweepstakes.Name} contestant's first name?");
                string lastName = UserInterface<string>.GetUserInputFor($"What is the {sweepstakes.Name} contestant's last name?");
                string email = UserInterface<string>.GetUserInputFor($"What is the {sweepstakes.Name} contestant's email?");
                int registration = Convert.ToInt32(UserInterface<string>.GetUserInputFor($"What is the {sweepstakes.Name} contestant's registration number?"));
                sweepstakes.RegisterContestant(new Contestant(firstName, lastName, email, registration));
            }
            _manager.InsertSweepstakes(sweepstakes);
        }

    }
}
