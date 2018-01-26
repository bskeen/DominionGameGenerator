using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultSeasideCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                #region Seaside (#371)

                new Card
                {
                    ID = 346,
                    Name = "Ambassador",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 347,
                    Name = "Bazaar",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 348,
                    Name = "Caravan",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 349,
                    Name = "Cutpurse",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 350,
                    Name = "Embargo",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 351,
                    Name = "Explorer",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 352,
                    Name = "Fishing Village",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 353,
                    Name = "Ghost Ship",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 354,
                    Name = "Haven",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 355,
                    Name = "Island",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 356,
                    Name = "Lighthouse",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 357,
                    Name = "Lookout",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 358,
                    Name = "Merchant Ship",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 359,
                    Name = "Native Village",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 360,
                    Name = "Navigator",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 361,
                    Name = "Outpost",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 362,
                    Name = "Pearl Diver",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 363,
                    Name = "Pirate Ship",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 364,
                    Name = "Salvager",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 365,
                    Name = "Sea Hag",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 366,
                    Name = "Smugglers",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 367,
                    Name = "Tactician",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 368,
                    Name = "Treasure Map",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 369,
                    Name = "Treasury",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 370,
                    Name = "Warehouse",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
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
                    ID = 371,
                    Name = "Wharf",
                    ExpansionID = expansionDict[Constants.SEASIDE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.SEASIDE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },

                #endregion Seaside (#371)
            };
        }
    }
}
