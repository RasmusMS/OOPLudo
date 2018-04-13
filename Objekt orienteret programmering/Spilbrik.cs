namespace Objekt_orienteret_programmering
{
    class Token
    {
        private readonly int Id;
        private readonly GameColor Color;
        private readonly TokenState State;
        private int Position;

        public Token(int TokenId, GameColor Clr, TokenState state, int TokenPosition)
        {
            this.Id = TokenId;
            this.Color = Clr;
            this.State = state;
            this.Position = TokenPosition;
        }

        public GameColor GetColor()
        {
            return this.Color;
        }

        public int GetToken()
        {
            return this.Id;
        }

        public TokenState GetState()
        {
            return this.State;
        }

        public int GetPosition()
        {
            return this.Position
                ;
        }
    }
}
