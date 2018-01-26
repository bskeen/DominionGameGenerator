using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.Models
{
    public class Card
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int ExpansionID { get; set; }
        public Expansion Expansion { get; set; }

        public IEnumerable<CardType> CardTypes { get; set; }

        public IEnumerable<CardCategory> CardCategories { get; set; }

        public int CoinCost { get; set; }
        public int DebtTokenCost { get; set; }
        public int PotionCost { get; set; }

        public IEnumerable<Card> DependentCards { get; set; } = new Card[0];
    }
}
