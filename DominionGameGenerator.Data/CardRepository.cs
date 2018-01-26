using DominionGameGenerator.Data.DefaultData;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominionGameGenerator.Data
{
    public class CardRepository : ICardRepository
    {
        public IEnumerable<Card> GetCardsForGame(IEnumerable<int> expansionIDs)
        {
            return DefaultCards.Cards.Where(x => expansionIDs.Contains(x.ExpansionID));
        }
    }

    public interface ICardRepository
    {
        IEnumerable<Card> GetCardsForGame(IEnumerable<int> expansionIDs);
    }
}
