# Litteraux de chaîne brute
Alias **raw string litteral**


C'est là que la syntaxe `"""` des littéraux de chaîne brute va nous être utile ! 

## Passer du texte en conservant sa mise en forme

Nous disposons du code xml suivant.

Nous voulons le passer dans une chaîne de caractères *xmlOutput* en conservant toute l'identation.

```xml
<file>
	<customer>
        <name>Eve</name>
        <city>Thiès</city>
        <birthdate>1996-03-17</birthdate>
	</customer>
	<customer>
        <name>Lory</name>
        <city>Ashgabat</city>
        <birthdate>1988-11-24</birthdate>
	</customer>
    <customer>
        <name>Arlina</name>
        <city>Minneapolis</city>
        <birthdate>1982-05-12</birthdate>
	</customer>
	<customer>
        <name>Molli</name>
        <city>Konya</city>
        <birthdate>2000-05-05</birthdate>
	</customer>
</file>
```

``` cs --region xml-sample --source-file ../src/Snippets/RawStringLitteral.cs --project ../src/Coding4FunWorkshop.csproj
```

**Suivant:  [Async & Tasks &raquo;](./async-tasks.md)**

**Précédent: [&laquo; Expression Switch](./switch-statement.md)**

**[Accueil](../README.md)**
