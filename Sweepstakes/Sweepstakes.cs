using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        Random rand;
        public string Name { get => name; set => name = value; }

        public Sweepstakes(string name)
        {
            this.Name = name;
            rand = new Random();
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
        }
        public Contestant PickWinner()
        {
            return contestants[rand.Next(contestants.Count)];
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface<string>.Print(contestant.ToString());
        }
    }
}
