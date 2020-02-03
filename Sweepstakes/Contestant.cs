using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit;
using MailKit.Net.Smtp;

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
            var message = new MimeMessage();
            if (winner)
            {
                message.From.Add(new MailboxAddress("Marketing Firm", "donotrespond@gmail.com"));
                message.To.Add(new MailboxAddress("Valued Contestant", emailAddress));
                message.Subject = "Congratulations!";
                message.Body = new TextPart("plain")
                {
                    Text = $"Congratulations {firstName} {lastName}, you won our sweepstakes!!!"
                };
                UserInterface<string>.Print($"Congratulations {firstName} {lastName}! You won the sweepstakes!");
            }
            else
            {
                message.From.Add(new MailboxAddress("Marketing Firm", "donotrespond@gmail.com"));
                message.To.Add(new MailboxAddress("Valued Contestant", emailAddress));
                message.Subject = "Sorry";
                message.Body = new TextPart("plain")
                {
                    Text = $"Sorry {firstName} {lastName}, you lost our sweepstakes. Try again next time."
                };
                UserInterface<string>.Print($"Sorry {firstName} {lastName}. You lost. Try again next time!");
            }
            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("devcodetestmail123", "passwordtest123");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}