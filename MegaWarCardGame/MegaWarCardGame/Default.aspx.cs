using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaWarCardGame
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void warButton_Click(object sender, EventArgs e)
        {
            Random Randomizer = new Random();
            Player Player1 = new Player("Chris");
            Player Player2 = new Player("Reality");
            DeckAssigner.DeckAssign(Player1, Player2, Randomizer);
            DeckFinalizer.ClarifyCards(Player1);
            DeckFinalizer.ClarifyCards(Player2);
            int counter = 0;
            int cardsCapt = 0;
            while ((Player1.CardsOwned.Count() > 0 && Player2.CardsOwned.Count() > 0) && counter < 5000)
            {
                cardsCapt = 1;
                if (Player1.CardsOwned[counter].CardNumber == Player2.CardsOwned[counter].CardNumber)
                {
                    if (Player1.CardsOwned.Count() > 4 && Player2.CardsOwned.Count() > 4)
                    {
                        cardsCapt = 0;
                        counter += WarCombat.warCombat(Player1, Player2, this, counter, cardsCapt);
                    }
                    else 
                    {
                        MakeLabel.AddLabel("</br>", this);
                        MakeImage.AddImage(Player1, counter, this);
                        MakeLabel.AddLabel(String.Format("  {0} vs {1}  ", Player1.Name, Player2.Name), this);
                        MakeImage.AddImage(Player2, counter, this);
                        MakeLabel.AddLabel(String.Format("{0} and {1} are locked in a heated battle. THIS IS WAR!!</br>", Player1.Name, Player2.Name), this);
                        MakeLabel.AddLabel("But someone ran out of cards!", this);
                        counter = 10000000; 
                    }
                }
                else if (Player1.CardsOwned[counter].CardNumber > Player2.CardsOwned[counter].CardNumber)
                {
                    NormalCombat.normalCombat(Player1, Player2, Player1, Player2, counter, this);
                }
                else if (Player1.CardsOwned[counter].CardNumber < Player2.CardsOwned[counter].CardNumber)
                {
                    NormalCombat.normalCombat(Player1, Player2, Player2, Player1, counter, this);
                }
                counter++;
            }

            resultLabel.Text = String.Format("</br> game has ended {2} has {0} cards and {3} has {1} cards!", Player1.CardsOwned.Count(), Player2.CardsOwned.Count(), Player1.Name, Player2.Name);
            if (Player1.CardsOwned.Count() > Player2.CardsOwned.Count()) resultLabel.Text += String.Format("{0} Wins!", Player1.Name);
            else if (Player2.CardsOwned.Count() > Player1.CardsOwned.Count()) resultLabel.Text += String.Format("{0} Wins!", Player2.Name);
            else if (Player1.CardsOwned.Count() == Player2.CardsOwned.Count()) resultLabel.Text += String.Format("The game has ended in a tie .... what randomness");
        }
    }
}