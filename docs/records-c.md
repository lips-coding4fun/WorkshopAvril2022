# Records

Les Records sont des tupes d'encapsulation des données, conçus pour être immutables.

## Aspirateur de site web 

Nous avons un aspirateur de site web qui stocke les données dans une classe CapturedWebsite.

Il ne dispose pas d'une base de données à part pour la classe "PageInfo", qui est redéfinie à chaque fois qu'il capture un site.

Un site capturé est donc défini avec `Address = new PageAddress()` à chaque fois.

Comment vérifier simplement que deux enregistrements concernent la même page web avec la fonction `IsSamePage` ?

**Si PageAddress est une classe, chaque new PageAddress() est une nouvelle instance.**

**En définissant plutôt PageAddress comme un record, chaque record ayant un domain + une page identique sera considéré comme le même site !**

```csharp
    public class CheckRecords
    {
        public static bool IsSamePage(CapturedPage pageA, CapturedPage pageB)
        {
            return pageA.Address == pageB.Address;
        }
    }

    public class CapturedPage
    {
        public PageAddress Address;
        public DateTime ScrapTime;
        public byte[] Content;
    }
    public record PageAddress
    {
        public string Domain;
        public string PageUri; 
    }
```