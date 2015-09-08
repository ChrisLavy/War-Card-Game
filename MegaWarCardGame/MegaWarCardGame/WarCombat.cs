using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public static class WarCombat
    {
        public static int warCombat(Player Player1, Player Player2, Default page, int counter, int cardsCapt)
        {
            
            MakeLabel.AddLabel("</br>", page);
            MakeImage.AddImage(Player1, (counter + cardsCapt), page);
            MakeLabel.AddLabel(String.Format("  {0} vs {1}  ", Player1.Name, Player2.Name), page);
            MakeImage.AddImage(Player2, (counter + cardsCapt), page);
            MakeLabel.AddLabel(String.Format("{0} and {1} are locked in a heated battle. THIS IS WAR!!</br>", Player1.Name, Player2.Name), page);

            MakeLabel.AddLabel(String.Format("{0}'s at stake pool:", Player1.Name), page);
            MakeImage.AddImage(Player1, (counter + 1 + cardsCapt), page);
            MakeImage.AddImage(Player1, (counter + 2 + cardsCapt), page);
            MakeImage.AddImage(Player1, (counter + 3 + cardsCapt), page);

            MakeLabel.AddLabel(String.Format("</br>{0}'s at stake pool:", Player2.Name), page);
            MakeImage.AddImage(Player2, (counter + 1 + cardsCapt), page);
            MakeImage.AddImage(Player2, (counter + 2 + cardsCapt), page);
            MakeImage.AddImage(Player2, (counter + 3 + cardsCapt), page);

            cardsCapt += 4;
                            
            if (Player1.CardsOwned[counter + cardsCapt].CardNumber == Player2.CardsOwned[counter + cardsCapt].CardNumber)
            {
                if (((Player1.CardsOwned.Count() + 4) > (8 + cardsCapt)) && (Player2.CardsOwned.Count() + 4) > (8 + cardsCapt))
                {
                    cardsCapt = warCombat(Player1, Player2, page, counter, cardsCapt);
                }
                else
                {
                    MakeLabel.AddLabel("</br>", page);
                    MakeImage.AddImage(Player1, counter + cardsCapt, page);
                    MakeLabel.AddLabel(String.Format("  {0} vs {1}  ", Player1.Name, Player2.Name), page);
                    MakeImage.AddImage(Player2, counter + cardsCapt, page);
                    MakeLabel.AddLabel(String.Format("{0} and {1} continue their stalemate. THE WAR RAGES ON!!</br>", Player1.Name, Player2.Name), page);
                    MakeLabel.AddLabel("But someone ran out of cards!", page);
                    cardsCapt = 10000000;

                }
            }

                else if (Player1.CardsOwned[counter + cardsCapt].CardNumber > Player2.CardsOwned[counter + cardsCapt].CardNumber)
                {
                    MakeLabel.AddLabel("</br>", page);
                    MakeImage.AddImage(Player1, counter + cardsCapt, page);
                    MakeLabel.AddLabel(String.Format("  {0} vs {1}  ", Player1.Name, Player2.Name), page);
                    MakeImage.AddImage(Player2, counter + cardsCapt, page);
                    MakeLabel.AddLabel(String.Format("{0} captured {1}'s unit and won the war!!!</br>", Player1.Name, Player2.Name), page);

                    MassCapture.massCapture(Player1, Player2, cardsCapt, counter);
                }

                else if (Player1.CardsOwned[counter + cardsCapt].CardNumber < Player2.CardsOwned[counter + cardsCapt].CardNumber)
                {
                    MakeLabel.AddLabel("</br>", page);
                    MakeImage.AddImage(Player1, counter + cardsCapt, page);
                    MakeLabel.AddLabel(String.Format("  {0} vs {1}  ", Player1.Name, Player2.Name), page);
                    MakeImage.AddImage(Player2, counter + cardsCapt, page);
                    MakeLabel.AddLabel(String.Format("{0} captured {1}'s unit and won the war!!!</br>", Player2.Name, Player1.Name), page);

                    MassCapture.massCapture(Player2, Player1, cardsCapt, counter);
                }
            

            
            return cardsCapt;
        }
    }
}