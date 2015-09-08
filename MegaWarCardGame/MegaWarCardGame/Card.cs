using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public class Card
    {
        public int CardNumber { get; set; }
        public string CardType { get; set; }
        public Card(int number, string cardType)
        {
            this.CardNumber = number;
            this.CardType = cardType;
        }
    }
}