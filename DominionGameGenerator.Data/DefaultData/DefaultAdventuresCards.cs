using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultAdventuresCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                
        #region Adventures (#58)

        new Card
                {
                    ID = 1,
                    Name = "Amulet",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 2,
                    Name = "Artificer",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 3,
                    Name = "Bridge Troll",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 4,
                    Name = "Caravan Guard",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE],
                        typeDict[Constants.REACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 5,
                    Name = "Dungeon",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 6,
                    Name = "Duplicate",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RESERVE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 7,
                    Name = "Gear",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 8,
                    Name = "Giant",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 9,
                    Name = "Guide",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RESERVE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 10,
                    Name = "Haunted Woods",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 11,
                    Name = "Hireling",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 6,
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
                    ID = 12,
                    Name = "Lost City",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 13,
                    Name = "Magpie",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 14,
                    Name = "Messenger",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 15,
                    Name = "Miser",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 16,
                    Name = "Ranger",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 17,
                    Name = "Ratcatcher",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RESERVE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 18,
                    Name = "Raze",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 19,
                    Name = "Royal Carriage",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RESERVE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 20,
                    Name = "Storyteller",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 21,
                    Name = "Swamp Hag",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 22,
                    Name = "Transmogrify",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RESERVE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 23,
                    Name = "Wine Merchant",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RESERVE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 24,
                    Name = "Port",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 25,
                    Name = "Coin of the Realm",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.RESERVE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 26,
                    Name = "Relic",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.ATTACK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 27,
                    Name = "Treasure Trove",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
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
                    ID = 28,
                    Name = "Distant Lands",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RESERVE_TYPE],
                        typeDict[Constants.VICTORY_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 29,
                    Name = "Page",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.TRAVELLER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 30,
                    Name = "Treasure Hunter",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.TRAVELLER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 31,
                    Name = "Warrior",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.TRAVELLER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 32,
                    Name = "Hero",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.TRAVELLER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 33,
                    Name = "Champion",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 34,
                    Name = "Peasant",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.TRAVELLER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 35,
                    Name = "Soldier",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.TRAVELLER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 36,
                    Name = "Fugitive",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.TRAVELLER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 37,
                    Name = "Disciple",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.TRAVELLER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 38,
                    Name = "Teacher",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RESERVE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 39,
                    Name = "Alms",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 40,
                    Name = "Ball",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 41,
                    Name = "Bonfire",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 42,
                    Name = "Borrow",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 43,
                    Name = "Expedition",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 44,
                    Name = "Ferry",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 45,
                    Name = "Inheritance",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 7,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 46,
                    Name = "Lost Arts",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 47,
                    Name = "Mission",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 48,
                    Name = "Pathfinding",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 8,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 49,
                    Name = "Pilgrimage",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 50,
                    Name = "Plan",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 51,
                    Name = "Quest",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 52,
                    Name = "Raid",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 53,
                    Name = "Save",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 1,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 54,
                    Name = "Scouting Party",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 55,
                    Name = "Seaway",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 56,
                    Name = "Trade",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 57,
                    Name = "Training",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 58,
                    Name = "Travelling Fair",
                    ExpansionID = expansionDict[Constants.ADVENTURES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.ADVENTURES_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },

                #endregion Adventures (#58)
            };
        }
    }
}
