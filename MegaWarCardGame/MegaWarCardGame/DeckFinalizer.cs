using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public static class DeckFinalizer
    {
        public static void ClarifyCards (Player Player)
        {
            int cycle = 0;
            foreach (double deckCardNumber in Player.CardsAssigned)
            {
                string cardType = CardAssigner.DetermineCard(deckCardNumber);
                int cardNumber = (int)CardAssigner.DetermineCardNumber(deckCardNumber);
                Player.CardsOwned.Add(cycle, new Card(cardNumber, cardType));
                cycle++;
            }
        }
    }
}