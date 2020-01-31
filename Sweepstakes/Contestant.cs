using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName, lastName, emailAddress;
        public int registrationNumber;

        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }
    }
}
