# Records

Les Records permettent 

## Aspirateur de site web 

Nous avons un aspirateur de site web qui stocke les données dans une classe CapturedWebsite.

Il ne dispose pas d'une base de données à part pour la classe "PageInfo", qui est redéfinie à chaque fois qu'il capture un site.

Un site capturé est donc défini avec `Address = new PageAdress()` à chaque fois.

Comment vérifier simplement que deux enregistrements concernent la même page web avec la fonction `IsSamePage` ?


``` cs --region try-records --source-file ../src/Snippets/Records.cs --project ../src/Coding4FunWorkshop.csproj
```

**Suivant:  [Fin de la session &raquo;](./congrats.md)**

**Précédent: [&laquo; Async & Tasks](./async-tasks.md)**

**[Sommaire](../index.md)**