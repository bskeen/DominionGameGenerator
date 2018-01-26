using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultDominionCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                #region Dominion (#177)

                new Card
                {
                    ID = 145,
                    Name = "Artisan",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 146,
                    Name = "Bandit",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 147,
                    Name = "Bureaucrat",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 4,
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
                    ID = 148,
                    Name = "Cellar",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 149,
                    Name = "Chapel",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 150,
                    Name = "Council Room",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 151,
                    Name = "Festival",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 152,
                    Name = "Gardens",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 6,
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
                    ID = 153,
                    Name = "Harbinger",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 154,
                    Name = "Laboratory",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 155,
                    Name = "Library",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 156,
                    Name = "Market",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 157,
                    Name = "Merchant",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 158,
                    Name = "Militia",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 4,
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
                    ID = 159,
                    Name = "Mine",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 160,
                    Name = "Moat",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 2,
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
                    ID = 161,
                    Name = "Moneylender",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 162,
                    Name = "Poacher",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 163,
                    Name = "Remodel",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 164,
                    Name = "Sentry",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 165,
                    Name = "Smithy",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 166,
                    Name = "Throne Room",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 167,
                    Name = "Vassal",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 168,
                    Name = "Village",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 169,
                    Name = "Witch",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 170,
                    Name = "Workshop",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
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
                    ID = 171,
                    Name = "Copper",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 0,
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
                    ID = 172,
                    Name = "Silver",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 3,
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
                    ID = 173,
                    Name = "Gold",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 6,
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
                    ID = 174,
                    Name = "Estate",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 2,
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
                    ID = 175,
                    Name = "Duchy",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 5,
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
                    ID = 176,
                    Name = "Province",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 8,
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
                    ID = 177,
                    Name = "Curse",
                    ExpansionID = expansionDict[Constants.DOMINION_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DOMINION_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.CURSE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.BASE_CATEGORY]
                    }
                },

                #endregion Dominion (#177)
            };
        }
    }
}
