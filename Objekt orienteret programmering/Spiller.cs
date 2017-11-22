using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt_orienteret_programmering
{
    public enum PlayerType {Menneske, Robot}

    class Spiller
    {
        public string Name;
        public int Id;
        public Spilbrik[] spilbrik;

        //Constructor
        public Spiller(string PlayerName, int PlayerId, PlayerType playerType, Spilbrik[] spilbrik)
        {
            this.Name = PlayerName;
            this.Id = PlayerId;
            this.spilbrik = spilbrik;
            this.color = tokens[0]
        }

        //Get method
        public string GetName()
        {
            return this.Name;
        }

        public color color
        {
            get;
        }

        public int GetPlayerId()
        {
            return this.Id;
        }
    }
}
