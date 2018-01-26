using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultAlchemyCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                
                #region Alchemy (#71)

                new Card
                {
                    ID = 59,
                    Name = "Alchemist",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 60,
                    Name = "Apothecary",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 61,
                    Name = "Apprentice",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 62,
                    Name = "Familiar",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 63,
                    Name = "Golem",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 64,
                    Name = "Herbalist",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 65,
                    Name = "Philosopher's Stone",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 66,
                    Name = "Possession",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 67,
                    Name = "Scrying Pool",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 68,
                    Name = "Transmute",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 69,
                    Name = "University",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 70,
                    Name = "Vineyard",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 1,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 71,
                    Name = "Potion",
                    ExpansionID = expansionDict[Constants.ALCHEMY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ALCHEMY_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.BASE_CATEGORY]
                    }
                },

                #endregion Alchemy (#71)
            };
        }
    }
}
