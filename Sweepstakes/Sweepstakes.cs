﻿using System;
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
        public string Name { get => name; set => name = value; }

        public Sweepstakes(string name)
        {
            this.Name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            
        }
        public Contestant PickWinner()
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
