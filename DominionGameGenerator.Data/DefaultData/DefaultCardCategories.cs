using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultCardCategories
    {
        private static IEnumerable<CardCategory> _cardCategories;
        public static IEnumerable<CardCategory> CardCategories
        {
            get
            {
                if (_cardCategories == null)
                {
                    InitCardCategories();
                }

                return _cardCategories;
            }
        }

        public static Dictionary<string, CardCategory> CardCategoryDictionary
        {
            get
            {
                return CardCategories.ToDictionary(x => x.Name);
            }
        }

        private static void InitCardCategories()
        {
            _cardCategories = new List<CardCategory>()
            {
                new CardCategory
                {
                    ID = 1,
                    Name = Constants.BASE_CATEGORY
                },
                new CardCategory
                {
                    ID = 2,
                    Name = Constants.EVENT_CATEGORY
                },
                new CardCategory
                {
                    ID = 3,
                    Name = Constants.KINGDOM_CATEGORY
                },
                new CardCategory
                {
                    ID = 4,
                    Name = Constants.OTHER_CATEGORY
                },
            };
        }
    }
}
