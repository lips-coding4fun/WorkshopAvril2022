using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding4FunWorkshop.Snippets
{
    public class AsyncWait
    {

        public int CodeHero()
        {
            #region code-hero
            // L'histoire du héros...
            #endregion
            return 0;
        }

        public int PastryQuest()
        {
            PastryQuestAsync();
            return 0;            
        }

        public async void PastryQuestAsync()
        {
            var pastries = new List<Pastry>() {
                Pastry.Macaron, Pastry.MilleFeuille, Pastry.Chouquette, Pastry.Eclair, Pastry.KouignAmann
            };

            #region wait-all-and-any
            // Ce code ne fonctionne que si c'est le Macaron qui est la première pâtisserie trouvée.
            // Avec les opérateurs d'attente, on peut lancer toutes les fonctions de manière asynchrone.
            var pastryLocations = new List<string>();
            
            foreach (var pastry in pastries)
            {
                pastryLocations.Add(await Quest.SearchPastryAsync(pastry));
            }

            Quest.DeliverFirstLocation(pastryLocations[0]);
            Quest.OpenBakery();
            Quest.DeliverAllLocations(pastryLocations);
            #endregion
        }

        //public async void PastryQuestCorrectionAsync()
        //{
        //    var pastries = new List<Pastry>() {
        //        Pastry.Macaron, Pastry.MilleFeuille, Pastry.Chouquette, Pastry.Eclair, Pastry.KouignAmann
        //    };

        //    #region wait-all-and-any-c
        //    var searches = new Task[5];

        //    foreach (var pastry in pastries)
        //    {
        //        searches.Append(Quest.SearchPastryAsync(pastry));
        //    }

        //    Task.WaitAny(searches);
        //    Quest.DeliverFirstLocation(;
        //    Quest.OpenBakery();
        //    Quest.DeliverAllLocations(pastryLocations);
        //    #endregion
        //}

    }

    internal enum Pastry
    {
        Macaron, MilleFeuille, Chouquette, Eclair, KouignAmann
    };

    internal class Quest
    {
        private static List<string> _expectedLocations = new();
        private static bool _bakeryOpen = false;

        internal static async Task<string> SearchPastryAsync(Pastry pastry)
        {
            return $"Castle {nameof(pastry)}";
        }

        internal static bool DeliverFirstLocation(string location)
        {
            
            if (_expectedLocations.Count > 0 && _expectedLocations.FirstOrDefault() == location && !_bakeryOpen)
                return true;
            return false;
        }

        internal static void OpenBakery()
        {
            _bakeryOpen = true;
        }

        internal static bool DeliverAllLocations(List<string> location)
        {
            return (_bakeryOpen && location.Count == 5);
        }
    }
}
