using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaWarCardGame
{
    public class Player
    {
        public List<double> CardsAssigned { get; set; }
        public Dictionary<int, Card> CardsOwned { get; set; }
        public string Name { get; set; }
        public int CardsOwnedMaxIndex { get; set; }
        public Player(string playerName)
        {
            this.CardsAssigned = new List<double>();
            this.CardsOwned = new Dictionary<int, Card>();
            this.CardsOwnedMaxIndex = 26;
            Name = playerName;
        }
    }
}