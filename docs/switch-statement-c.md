# Switch Statement / Expression Switch

*L'expression switch* permet de récupérer une valeur directement selon la valeur évaluée dans le switch.

Ci-dessous, en fonction de `recipe`, on choisit le bon `OvenParameters` qui stocke le four.

## Pierre-Feuille-Ciseaux

Refactoriser la fonction GetWinner ci-dessous en remplaçant l'instruction switch par une **expresion switch**.

`GetWinner()` doit retourner une chaîne contenant le gagnant et la main jouée par le gagnant.
- Format : `Player 2 wins with Paper.`
- En cas d'égalité, retourner : `It's a tie`

En utilisant l'écriture sous forme d'expression, on peut obtenir ceci :

```csharp
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
```