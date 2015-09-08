using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MegaWarCardGame
{
    public class MakeImage
    {
        public static void AddImage(Player Player, int counter, Default page)
        {
            Image myImage = new Image();
            myImage.ImageUrl = "Images/" + Player.CardsOwned[counter].CardNumber + Player.CardsOwned[counter].CardType + ".png";
            myImage.Visible = true;
            page.Controls.Add(myImage);
        }
    }
}