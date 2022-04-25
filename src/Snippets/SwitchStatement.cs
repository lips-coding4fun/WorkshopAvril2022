namespace Coding4FunWorkshop.Snippets
{
    public class SwitchStatement
    {
        public enum Hand { Rock, Paper, Scissors };
        public int RockPaperScissors()
        {
            var playerOneHands = new List<Hand>() { Hand.Scissors, Hand.Paper, Hand.Rock };
            var playerTwoHands = new List<Hand>() { Hand.Rock, Hand.Paper, Hand.Scissors };

            foreach (var playerOneHand in playerOneHands)
            {
                foreach (var playerTwoHand in playerTwoHands)
                {
                    if (GetWinnerExpression(playerOneHand, playerTwoHand) != GetWinner(playerOneHand, playerTwoHand))
                    {
                        Console.WriteLine($"Result not expected for match: {playerOneHand} vs {playerTwoHand}:" +
                            $"Expected: {GetWinnerExpression(playerOneHand, playerTwoHand)}" +
                            $"Result: {GetWinner(playerOneHand, playerTwoHand)}");
                    }
                }
            }

            return 0;
        }

        public string GetWinnerExpression(Hand playerOne, Hand playerTwo)
        => (playerOne, playerTwo) switch
        {
            (Hand.Rock, Hand.Paper) => "Player 2 wins with Paper.",
            (Hand.Rock, Hand.Scissors) => "Player 1 wins with Rock.",
            (Hand.Paper, Hand.Rock) => "Player 1 wins with Paper.",
            (Hand.Paper, Hand.Scissors) => "Player 2 wins with Scissors.",
            (Hand.Scissors, Hand.Rock) => "Player 2 wins with Rock.",
            (Hand.Scissors, Hand.Paper) => "Player 1 wins with Scissors.",
            (_, _) => "It's a tie."
        };

        // Refactoriser la fonction GetWinner ci-dessous en remplaçant l'instruction switch par une **expresion switch**.
        // `GetWinner()` doit retourner une chaîne contenant le gagnant et la main jouée par le gagnant.
        // - Format : `Player 2 wins with Paper.`
        // - En cas d'égalité, retourner : `It's a tie`
        // Si l'expression est bien faite, son contenu ne fera que 7 lignes !
        #region switch-statement
        public string GetWinner(Hand playerOne, Hand playerTwo)
        {
            switch(playerOne)
            { 
                case Hand.Rock:
                    switch(playerTwo)
                    {
                        case Hand.Paper:
                            return "Player 2 wins with Paper.";
                        case Hand.Scissors:
                            return "Player 1 wins with Rock.";
                        default: 
                            return "It's a tie";
                    }
                case Hand.Paper:
                    switch (playerTwo)
                    {

                        case Hand.Rock:
                            return "Player 1 wins with Paper.";
                        case Hand.Scissors:
                            return "Player 2 wins with Scissors.";
                        default:
                            return "It's a tie";
                    }
                    break;
                case Hand.Scissors:
                    switch (playerTwo)
                    {

                        case Hand.Rock:
                            return "Player 2 wins with Rock.";
                        case Hand.Paper:
                            return "Player 1 wins with Scissors.";
                        default:
                            return "It's a tie";
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

    }
}