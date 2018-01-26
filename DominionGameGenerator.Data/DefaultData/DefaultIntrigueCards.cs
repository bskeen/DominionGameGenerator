using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultIntrigueCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                #region Intrigue (#318)
                
                new Card
                {
                    ID = 293,
                    Name = "Baron",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 4,
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
                    ID = 294,
                    Name = "Bridge",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 4,
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
                    ID = 295,
                    Name = "Conspirator",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 4,
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
                    ID = 296,
                    Name = "Courtier",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
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
                    ID = 297,
                    Name = "Courtyard",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
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
                    ID = 298,
                    Name = "Diplomat",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.REACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 299,
                    Name = "Duke",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
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
                    ID = 300,
                    Name = "Harem",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.VICTORY_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 301,
                    Name = "Ironworks",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 4,
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
                    ID = 302,
                    Name = "Lurker",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
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
                    ID = 303,
                    Name = "Masquerade",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 3,
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
                    ID = 304,
                    Name = "Mill",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.VICTORY_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 305,
                    Name = "Mining Village",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 4,
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
                    ID = 306,
                    Name = "Minion",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
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
                    ID = 307,
                    Name = "Nobles",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.VICTORY_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 308,
                    Name = "Patrol",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
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
                    ID = 309,
                    Name = "Pawn",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
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
                    ID = 310,
                    Name = "Replace",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
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
                    ID = 311,
                    Name = "Secret Passage",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 4,
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
                    ID = 312,
                    Name = "Shanty Town",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 3,
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
                    ID = 313,
                    Name = "Steward",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 3,
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
                    ID = 314,
                    Name = "Swindler",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
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
                    ID = 315,
                    Name = "Torturer",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
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
                    ID = 316,
                    Name = "Trading Post",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
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
                    ID = 317,
                    Name = "Upgrade",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
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
                    ID = 318,
                    Name = "Wishing Well",
                    ExpansionID = expansionDict[Constants.INTRIGUE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.INTRIGUE_EXPANSION],
                    CoinCost = 3,
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

                #endregion Intrigue (#318)
            };
        }
    }
}
