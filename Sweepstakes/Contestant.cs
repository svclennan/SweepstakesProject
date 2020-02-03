using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : IObserver
    {
        public string firstName, lastName, emailAddress;
        public int registrationNumber;
        public bool winner;

        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
            this.winner = false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(firstName);
            sb.Append(" ");
            sb.Append(lastName);
            sb.Append(", ");
            sb.Append(emailAddress);
            sb.Append(", ");
            sb.Append(registrationNumber);
            return sb.ToString();
        }
        public void NotifyContestants()
        {
            if (winner)
            {
                UserInterface<string>.Print($"Congratulations {firstName} {lastName}! You won the sweepstakes!");
            }
            else
            {
                UserInterface<string>.Print($"Sorry {firstName} {lastName}. You lost. Try again next time!");
            }
        }
    }
}