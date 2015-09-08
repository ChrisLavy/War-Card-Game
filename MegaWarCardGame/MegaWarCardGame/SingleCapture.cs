using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public static class SingleCapture
    {
        public static void captureCards(Player Winner, Player Loser, int counter)
        {
            Winner.CardsOwned.Add(Winner.CardsOwnedMaxIndex, new Card(Winner.CardsOwned[counter].CardNumber, Winner.CardsOwned[counter].CardType));
            Winner.CardsOwnedMaxIndex++;
            Winner.CardsOwned.Remove(counter);
            Winner.CardsOwned.Add(Winner.CardsOwnedMaxIndex, new Card(Loser.CardsOwned[counter].CardNumber, Loser.CardsOwned[counter].CardType));
            Winner.CardsOwnedMaxIndex++;
            Loser.CardsOwned.Remove(counter);
            
            
        }
    }
}