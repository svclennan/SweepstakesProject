using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.RunGame();
            //Sweepstakes ss = new Sweepstakes("Million Dollar Car");
            //ss.RegisterContestant(new Contestant("Sean", "Clennan", "emailAddress@gmail.com", 1234));
            //ss.RegisterContestant(new Contestant("Zac", "Butt", "123@gmail.com", 54839));
            //ss.RegisterContestant(new Contestant("Wall", "E", "robot@gmail.com", 889320));
            //ss.RegisterContestant(new Contestant("Sweep", "Stakes", "ss@gmail.com", 032190));
            //ss.RegisterContestant(new Contestant("Yeti", "Water", "bottle@gmail.com", 669328));
            //ss.RegisterContestant(new Contestant("Blen", "Der", "watter@gmail.com", 4423632));
            //ss.RegisterContestant(new Contestant("G", "Fuel", "gamerCrack@gmail.com", 66666666));
            //ss.RegisterContestant(new Contestant("MSI", "Laptop", "expensive@gmail.com", 4218042));
            //ss.RegisterContestant(new Contestant("Moni", "Tor", "screen@gmail.com", 07734));
            //simulation.marketingFirm._manager.InsertSweepstakes(ss);
            //simulation.marketingFirm.CreateSweepstakes();
            //Sweepstakes sweep = simulation.marketingFirm._manager.GetSweepstakes();
            //Console.WriteLine(sweep.PickWinner());
            Console.ReadLine();
        }
    }
}
