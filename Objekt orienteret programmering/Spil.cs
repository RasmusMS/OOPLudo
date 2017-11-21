using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Objekt_orienteret_programmering
{
    class Spil
    {
        private int delay = 500;
        public int PNr = 0;

        //Constructor
        public Spil()
        {
            Console.WriteLine("Velkommen til Ludo");
            Thread.Sleep(delay);
            Console.WriteLine("Du kan finde reglerne inde på: http://www.papskubber.dk/braetspil/ludo");
            Thread.Sleep(delay);
            PlayerNr();
            TakeTurns();
        }

        //Method - Antal spillere, spiller navne, spiller farve.
        public void PlayerNr()
        {
            Console.WriteLine("Hvor mange spillere vil i være?");

            while (PNr < 2 || PNr > 4)
            {
                Thread.Sleep(delay);
                if (!int.TryParse(Convert.ToString(Console.ReadLine()), out this.PNr))
                {
                    Console.WriteLine(PNr);
                }
            }
        }

        private void TakeTurns()
        {
            Dice dice1 = new Dice(6);

            Console.WriteLine("Kast blev: " + dice1.ThrowDice().ToString());

            Console.ReadKey();
        }
    }
}
