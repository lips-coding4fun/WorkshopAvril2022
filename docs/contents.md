= New Features

== Switch Statement : exercice

Refactoriser la fonction GetWinner ci-dessous en remplaçant l'instruction switch par une expresion switch.
GetWinner doit retourner le gagnant et ce qui a été joué par le gagnant.

enum Hand { Rock, Paper, Scissors }



== Switch Statement : correction
[source,csharp]
----
public string GetWinner(Hand playerOne, Hand playerTwo)
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
----


== Async/await : exercice

Notre classe Hero permet le déplacement d'un personnage.
Hero dispose de fonctions asynchrones :
DetectGroundAsync() : toutes les 2 secondes, détecte si le héros peut avancer.
AimBossAsync() : parcourt l'écran pour trouver les coordonnées du boss.

Actions disponibles :
Hero.Shield() : le héros se protège du tir du boss. Cette action est interrompue

Hero.Move() : le héros se déplace devant lui. Il perd s'il n'y a pas de sol devant lui.
Hero.Shoot(Coords coordinates) : le héros tire aux coordonnées indiquées.

Utilisez l'asynchronisme pour aider notre héros à s'en sortir !

== Async/await : code d'origine proposé
[source,csharp]
----
private void Main()
{
    Hero.Shield();
    Hero.Move();    // Game over 1 : le héros tombe car il n'y a pas de sol.
    Hero.Shield();
    var bossCoordinates =  Hero.AimBossAsync().Result;
    Hero.Shoot(); // Game over 2 : Le héros ne tire pas sur le boss (car les coordonnées ne sont pas attendues).
};
----

== Async/await : correction
[source,csharp]
----
private async void Main()
{
    Hero.Shield();
    await Hero.DetectGroundAsync());
    Hero.Move();
    Hero.Shield();
    var bossCoordinates = await Hero.AimBossAsync();
    Hero.Shoot(bossCoordinates);
};
----