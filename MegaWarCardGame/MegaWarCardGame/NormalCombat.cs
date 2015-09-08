using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public static class NormalCombat
    {
        public static void normalCombat(Player Player1, Player Player2, Player Winner, Player Loser, int counter, Default page)
        {           
            MakeImage.AddImage(Player1, counter, page);
            MakeLabel.AddLabel(String.Format("{0} vs {1}", Player1.Name, Player2.Name), page);
            MakeImage.AddImage(Player2, counter, page);
            MakeLabel.AddLabel(String.Format("{0} has captured {1}'s unit!</br>", Winner.Name, Loser.Name), page);

            SingleCapture.captureCards(Winner, Loser, counter);
        }
    }
}