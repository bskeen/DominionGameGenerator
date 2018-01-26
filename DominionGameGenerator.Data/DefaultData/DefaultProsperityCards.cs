using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultProsperityCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                #region Prosperity (#345)
                
                new Card
                {
                    ID = 319,
                    Name = "Bank",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 7,
                    PotionCost = 0,
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
                    ID = 320,
                    Name = "Bishop",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 321,
                    Name = "City",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 322,
                    Name = "Colony",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 11,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.BASE_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 323,
                    Name = "Contraband",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
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
                    ID = 324,
                    Name = "Counting House",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 325,
                    Name = "Expand",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 7,
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
                    ID = 326,
                    Name = "Forge",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 7,
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
                    ID = 327,
                    Name = "Goons",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 6,
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
                    ID = 328,
                    Name = "Grand Market",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 6,
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
                    ID = 329,
                    Name = "Hoard",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
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
                    ID = 330,
                    Name = "King's Court",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 7,
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
                    ID = 331,
                    Name = "Loan",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
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
                    ID = 332,
                    Name = "Mint",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 333,
                    Name = "Monument",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 334,
                    Name = "Mountebank",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 335,
                    Name = "Peddler",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 8,
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
                    ID = 336,
                    Name = "Platinum",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 9,
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
                new Card
                {
                    ID = 337,
                    Name = "Quarry",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
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
                    ID = 338,
                    Name = "Rabble",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 339,
                    Name = "Royal Seal",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
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
                    ID = 340,
                    Name = "Talisman",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
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
                    ID = 341,
                    Name = "Trade Route",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 342,
                    Name = "Vault",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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
                    ID = 343,
                    Name = "Venture",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
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
                    ID = 344,
                    Name = "Watchtower",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
                    CoinCost = 3,
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
                    ID = 345,
                    Name = "Worker's Village",
                    ExpansionID = expansionDict[Constants.PROSPERITY_EXPANSION].ID,
                    Expansion = expansionDict[Constants.PROSPERITY_EXPANSION],
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

                #endregion Prosperity (#345)
            };
        }
    }
}
