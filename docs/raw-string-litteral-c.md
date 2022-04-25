# Litteraux de chaîne brute
Alias **raw string litteral**


C'est là que la syntaxe `"""` des littéraux de chaîne brute va nous être utile ! 

## Passer du texte en conservant sa mise en forme

Nous disposons du code xml suivant.

Nous voulons le passer dans une chaîne de caractères *xmlOutput* en conservant toute l'identation.
La syntaxe qui fonctionne (à partir de C# 11) est comme ceci :
```csharp
string xmlOutput = """
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
    """;
```