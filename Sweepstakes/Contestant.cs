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
    }
}