using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public static class DeckAssigner
    {
        public static List<double> StandardDeck = new List<double>();

        public static void DeckAssign(Player Player1, Player Player2, Random Randomizer)
        {
            for (int i = 1; i < 53; i++) {StandardDeck.Add(i);}
            StandardDeck = StandardDeck.OrderBy(item => Randomizer.Next()).ToList();
            int tracker = StandardDeck.Count();
            while (tracker > 0 && Player1.CardsAssigned.Count() < 26)
            {
                Player1.CardsAssigned.Add(StandardDeck[tracker - 1]);
                tracker--;
                Player2.CardsAssigned.Add(StandardDeck[tracker - 1]);
                tracker--;
            }
        }

        
        
        
        
    }
}