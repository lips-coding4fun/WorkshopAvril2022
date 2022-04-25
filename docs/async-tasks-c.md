# Async & Tasks

L'utilisation de *l'asynchrone* permet d'attendre le résultat d'un traitement pour continuer le programme, ou au contraire de ne pas bloquer le programme lorsqu'une action potentiellement bloquante a lieu.

## Attendre un, et attendre plusieurs

- Un noble pâtissier se met à la recherche des Cinq pâtisseries légendaires.
- Une recherche est une méthode asynchrone `Quest.SearchPastryAsync(pastry)`. Le résultat de la recherche est la position du gâteau.
- Dès qu'il en trouve au moins une, il doit envoyer sa position avec `Quest.DeliverFirstLocation(location)`.
- Il doit ensuite ouvrir sa boutique avec `Quest.OpenBakery()`
- Et une fois seulement qu'il a trouvé les cinq gâteaux, il doit envoyer leurs position dans la fonction `Quest.DeliverAllLocations(location)`.

 ```csharp
var pastryLocations = new List<string>();
var pendingQuests = new Task[5];

foreach (var pastry in pastries)
{
    var quest = Quest.SearchPastryAsync(pastry);
    pendingQuests.Append(quest);
    quest.start;
}

var firstCompletedQuest = pendingQuests[Task.WaitAny(pendingQuests)];
Quest.DeliverFirstLocation(firstCompletedQuest);

pendingQuests.WaitAll();
Quest.OpenBakery();
```