using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt_orienteret_programmering
{
    class Spiller
    {
        public void PlayerNr()
        {
            int PNr = 0;

            do
            {
                Console.WriteLine("Hvor mange spillere vil i være?");
                PNr = Convert.ToInt32(Console.ReadLine());

                if (PNr >= 2 && PNr <= 4)
                {

                }
                else
                {
                    Console.WriteLine("Man kan kun spille mellem 2 og 4 spillere");
                    Console.WriteLine();
                }
            } while (PNr < 2 || PNr > 4);

            Console.ReadKey();
        }
    }
}
