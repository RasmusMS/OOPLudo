using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt_orienteret_programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            Spil SpilStart = new Spil();

            Console.ReadKey();
        }

        /*static void ThrowDicesUntilSix()
        {
            Dice dice1 = new Dice(6);

            
            Console.WriteLine("Kast blev: " + dice1.ThrowDice());
            

            Console.ReadKey();
        }*/
    }
}
