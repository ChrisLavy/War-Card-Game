using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public static class CardAssigner
    {
        public static string DetermineCard(double number)
        {
            if ((number / 4) % 1 == 0) { return "ofSpades"; }
            else if (((number / 4) + .25) % 1 == 0) { return "ofClubs"; }
            else if (((number / 4) + .5) % 1 == 0) { return "ofHearts"; }
            else if (((number / 4) + .75) % 1 == 0) { return "ofDiamonds"; }
            else return "";
        }
        public static double DetermineCardNumber(double number)
        {
            if (((number / 4) % 1) == 0) { return ((number / 4) + 1); }
            else if ((((number / 4) + .25) % 1) == 0) { return ((number / 4) + 1.25); }
            else if ((((number / 4) + .5) % 1) == 0) { return ((number / 4) + 1.5); }
            else if ((((number / 4) + .75) % 1) == 0) { return ((number / 4) + 1.75); }
            else return 0;
        }
    }
}