using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MegaWarCardGame
{
    public class MakeLabel
    {
        public static void AddLabel(string labelScript, Default page)
        {
            Label label = new Label();
            label.Text = string.Format("{0}", labelScript);
            label.Visible = true;
            page.Controls.Add(label);
        }
    }
}