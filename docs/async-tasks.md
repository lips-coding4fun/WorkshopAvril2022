# Async & Tasks

L'utilisation de *l'asynchrone* permet d'attendre le résultat d'un traitement pour continuer le programme, ou au contraire de ne pas bloquer le programme lorsqu'une action potentiellement bloquante a lieu.

## Attendre un, et attendre plusieurs

- Un noble pâtissier se met à la recherche des Cinq pâtisseries légendaires.
- Une recherche est une méthode asynchrone `Quest.SearchPastryAsync(pastry)`. Le résultat de la recherche est la position du gâteau.
- Dès qu'il en trouve au moins une, il doit envoyer sa position avec `Quest.DeliverFirstLocation(location)`.
- Quand il a trouvé tous les gâteaux, il peut ouvrir sa boutique avec `Quest.OpenBakery()`

``` cs --region wait-all-and-any --source-file ../src/Snippets/AsyncWait.cs --project ../src/Coding4FunWorkshop.csproj
```

**Suivant:  [Les Records &raquo;](./records.md)**

**Précédent: [&laquo; Littéraux de chaînes brutes](./raw-string-litteral.md)**

**[Sommaire](../index.md)**