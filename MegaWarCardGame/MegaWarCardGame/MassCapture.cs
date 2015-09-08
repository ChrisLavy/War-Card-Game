using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public static class MassCapture
    {
        public static void massCapture(Player Winner, Player Loser, int cardsCapt, int counter)
        {
            for (int i = 0; i <= cardsCapt; i++)
            {
                SingleCapture.captureCards(Winner, Loser, counter + i);
            }
        }
    }
}