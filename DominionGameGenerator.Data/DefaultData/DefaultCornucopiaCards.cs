using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultCornucopiaCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                #region Cornucopia (#89)
                
                new Card
                {
                    ID = 72,
                    Name = "Farming Village",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 73,
                    Name = "Fortune Teller",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 74,
                    Name = "Hamlet",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 75,
                    Name = "Harvest",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 76,
                    Name = "Horn of Plenty",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 77,
                    Name = "Horse Traders",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 78,
                    Name = "Hunting Party",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 79,
                    Name = "Jester",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 80,
                    Name = "Menagerie",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 81,
                    Name = "Remake",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 82,
                    Name = "Tournament",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 83,
                    Name = "Young Witch",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 84,
                    Name = "Fairgrounds",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
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
                    ID = 85,
                    Name = "Bag of Gold",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.PRIZE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 86,
                    Name = "Diadem",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.PRIZE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 87,
                    Name = "Followers",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.PRIZE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 88,
                    Name = "Princess",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.PRIZE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 89,
                    Name = "Trusty Steed",
                    ExpansionID = expansionDict[Constants.CORNUCOPIA_EXPANSION].ID,
                    Expansion = expansionDict[Constants.CORNUCOPIA_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.PRIZE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },

                #endregion Cornucopia (#89)
            };
        }
    }
}
