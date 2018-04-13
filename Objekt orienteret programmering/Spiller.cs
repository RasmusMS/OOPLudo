namespace Objekt_orienteret_programmering
{
    class Player
    {
        public string Name;
        public int Id;
        public Token[] token;
        private GameColor color;

        //Constructor
        public Player(string PlayerName, int PlayerId, Token[] token, GameColor color)
        {
            this.Name = PlayerName;
            this.Id = PlayerId;
            this.token = token;
            this.color = color;
        }

        public Token[] GetTokens()
        {
            return token;
        }

        //Get method
        public string GetName()
        {
            return this.Name;
        }

        public GameColor Color
        {
            get => this.color;
        }

        public int GetPlayerId()
        {
            return this.Id;
        }

        public string GetDescription()
        {
            return "Spiller #" + this.GetPlayerId() + " hedder: " + this.GetName() + " og har farven: " + this.Color;
        }
    }
}