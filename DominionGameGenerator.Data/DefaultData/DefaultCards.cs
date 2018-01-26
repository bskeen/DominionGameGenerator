using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public class DefaultCards
    {
        private static IEnumerable<Card> _cards;
        public static IEnumerable<Card> Cards
        {
            get
            {
                if (_cards == null)
                {
                    InitCardCategories();
                }

                return _cards;
            }
        }

        private static void InitCardCategories()
        {
            var categoryDict = DefaultCardCategories.CardCategoryDictionary;
            var typeDict = DefaultCardTypes.CardTypeDictionary;
            var expansionDict = DefaultExpansions.ExpansionDictionary;
            List<Card> list = new List<Card>();

            list.AddRange(DefaultAdventuresCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultAlchemyCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultCornucopiaCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultDarkAgesCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultDominionCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultEmpiresCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultGuildsCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultHinterlandsCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultIntrigueCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultProsperityCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultSeasideCards.GetDefaultCards(expansionDict, typeDict, categoryDict));
            list.AddRange(DefaultNocturneCards.GetDefaultCards(expansionDict, typeDict, categoryDict));

            _cards = list;
        }
    }
}
