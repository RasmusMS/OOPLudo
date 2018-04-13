using System;

namespace Objekt_orienteret_programmering
{
    public class Dice
    {
        private int faces;
        private int LastValue;
        private Random rnd;

        //Constructor
        public Dice(int numberOfFaces)
        {
            this.faces = numberOfFaces;
            this.rnd = new Random();
        }

        //Method - throws dice
        public int ThrowDice()
        {
            int result;

            result = rnd.Next(1, (this.faces + 1));
            this.LastValue = result;
            return result;
        }

        //Method - saves last dice
        public int GetLastValue()
        {
            return this.LastValue;
        }
    }
}
