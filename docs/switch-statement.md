# Switch Statement / Expression Switch

*L'expression switch* permet de récupérer une valeur directement selon la valeur évaluée dans le switch.

Ci-dessous, en fonction de `recipe`, on choisit le bon `OvenParameters` qui stocke le four.

```cs
OvenParameters ovenParams = recipe switch
{
    Recipe.Bread    => new OvenParameters(250, 20);
    Recipe.Pizza    => new OvenParameters(220, 12);
    Recipe.Cake     => new OvenParameters(180, 20);
    _               => throw new ArgumentException(message: "invalid enum value", paramName: nameof(recipe));
};
```

## Pierre-Feuille-Ciseaux

Refactoriser la fonction GetWinner ci-dessous en remplaçant l'instruction switch par une **expresion switch**.

`GetWinner()` doit retourner une chaîne contenant le gagnant et la main jouée par le gagnant.
- Format : `Player 2 wins with Paper.`
- En cas d'égalité, retourner : `It's a tie`

Si l'expression est bien faite, son contenu ne fera que 7 lignes !

``` cs --region switch-statement --source-file ../src//Snippets/SwitchStatement.cs --project ../src/Coding4FunWorkshop.csproj
```

## Une petite astuce
On peut faire un switch sur un tuple :
```cs
return (modificatorKey, letterKey) switch
{
    (Key.Ctrl, Key.C) => Command.Copy,
    (Key.Ctrl, Key.X) => Command.Cut,
    (Key.Ctrl, Key.P) => Command.Paste,
    // ...
}
```
**Suivant:  [Interpolation de chaînes &raquo;](./raw-string-litteral.md)**

**Précédent: [&laquo; Sommaire](../index.md)**

**[Sommaire](../index.md)**