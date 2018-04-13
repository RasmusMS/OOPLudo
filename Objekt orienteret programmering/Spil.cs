using System;

namespace Objekt_orienteret_programmering
{
    public enum GameColor {Blå, Rød, Grøn, Gul}
    public enum TokenState {InPlay, Home, Safe, Finished}

    public class Game
    {
        protected int delay = 300; // -- Delays with 300 miliseconds
        private int NumberOfPlayers = 0; // -- Antal af spillere der spiller.
        private Player[] players;
        private Token[] tokens;
        private Dice dice1;
        private bool ThrowRepeat = true;
        private int TokenPosition = 0;

        //Constructor
        public Game()
        {
            Write("Velkommen til Ludo", delay);
            Space();
            Write("Du kan finde reglerne inde på: http://www.papskubber.dk/braetspil/ludo", delay);
            Space();
            Space();
            SetPlayerNumber(); // -- Her vælges hvor mange spillere der er.
            PlayerCreation(); // -- Her laves de forskellige spillere.
            ShowThePlayers(); // -- Her viser den de forskellige spillere.
            TakeTurns();
        }

        //Method - Antal spillere
        private void SetPlayerNumber()
        {
            Write("Hvor mange spillere vil i være: ", delay);

            while (!int.TryParse(Console.ReadLine(), out this.NumberOfPlayers) || NumberOfPlayers < 2 || NumberOfPlayers > 4) // -- Tjekker om det er det rigtige der indtastes og giver værdien til NumberOfPlayers
            {
                Write("Du skal skrive et tal mellem 2 og 4.", delay);
                Space();
                Space();
                Write("Hvor mange spillere vil i være: ");
            }
        }

        private void PlayerCreation()
        {
            this.players = new Player[this.NumberOfPlayers]; // -- Laver et array på størrelsen af hvor mange spillere der skal være

            for (int iz = 0; iz < NumberOfPlayers; iz++) // -- Et loop der laver alle spillerne
            {
                Write("Hvad hedder spiller #" + (iz+1) + ": ");
                string name = Console.ReadLine();

                Token[] Tkn = AssignTokens(iz);

                players[iz] = new Player(name, (iz+1), Tkn, Tkn[iz].GetColor());
            }
            Space();
        }

        private Token[] AssignTokens(int colorIndex) // -- Denne methode bruges i player oprettelses delen til at tildele brikkerne til spillerne.
        {
            tokens = new Token[4];

            for (int ika = 0; ika <= 3; ika++) // -- En counter der sørger for at den køres igennem 4 gange så hver spiller får 4 brikker.
            {
                switch (colorIndex)
                {
                    case 0: // -- Dette bliver spiller 1's brikker -- //
                        tokens[ika] = new Token((ika + 1), GameColor.Blå, TokenState.Home, TokenPosition);
                        break;

                    case 1: // -- Dette bliver spiller 2's brikker -- //
                        tokens[ika] = new Token((ika + 1), GameColor.Rød, TokenState.Home, TokenPosition);
                        break;

                    case 2: // -- Dette bliver spiller 3's brikker -- //
                        tokens[ika] = new Token((ika + 1), GameColor.Grøn, TokenState.Home, TokenPosition);
                        break;

                    case 3: // -- Dette bliver spiller 4's brikker -- //
                        tokens[ika] = new Token((ika + 1), GameColor.Gul, TokenState.Home, TokenPosition);
                        break;
                }
            }
            return tokens;
        }

        private void ShowThePlayers() // -- En methode der viser de oprettede spillere
        {
            Write("Her er dine spillere:", delay);
            Space();
            foreach (Player pl in this.players) // -- Denne kører en gang for hver oprettede spiller.
            {
                Write(pl.GetDescription(), delay);
                Space();
            }
            Space();
        }

        private void TakeTurns()
        {
            foreach (Player pl in this.players) // -- Kører en gang for hver spiller
            {
                do
                {
                    string plName = pl.Name;
                    Write("Nu er det " + plName + " tur.");
                    Space();
                    Write("Tryk 'k' for at kaste terningen: ");
                    char kast = Convert.ToChar(Console.ReadLine());
                    if (kast == 'k' || kast == 'K')
                    {
                        dice1 = new Dice(6); // -- Laver en ny terning
                        Write("Kast blev: " + dice1.ThrowDice().ToString()); // -- Kaster terningen som generere et random nummer mellem 1 og 6
                        Space();
                        ThrowRepeat = false;
                    }
                    else
                    {
                        Write("Du skal skrive 'k' for at kaste terningen.");
                        ThrowRepeat = true;
                        Space();
                    }
                    Space();
                } while (ThrowRepeat == true);
                WhichToMove(pl.GetTokens());
            }
        }

        private void WhichToMove(Token[] Tkn) // -- Denne methode bruges til at tjekke hvilke brikker en spiller kan rykke med
        {
            foreach (Token tkn in Tkn) // -- Kører en gang for hver token
            {
                Write("Brik #" + tkn.GetToken().ToString() + " er " + tkn.GetState() + ": ");
                switch (tkn.GetState())
                {
                    case TokenState.Home:
                        if (dice1.GetLastValue() == 6)
                        {
                            Write("<-- Kan spilles.", delay); // -- Brikken er ikke ude endnu men kan spilles
                        }
                        else
                        {
                            Write("<-- Kan IKKE spilles.", delay); // -- Brikken er ikke ude og kan ikke spilles
                        }
                        break;

                    case TokenState.InPlay:
                        Write("<-- Kan spilles.", delay); // -- Brikken er ude og kan spilles
                        break;

                    case TokenState.Safe:
                        Write("<-- Kan spilles.", delay); // -- Brikken er ude og kan spilles
                        break;

                    case TokenState.Finished:
                        Write("<-- Gennemført.", delay); // -- Brikken er færdig og kan derfor ikke spilles længere.
                        break;
                }
                Space();
            }
            Space();
        }

        private void Write(string txt, int dl = 0)
        {
            System.Threading.Thread.Sleep(dl);
            Console.Write(txt);
        }

        private void Space()
        {
            Console.WriteLine();
        }
    }
}
