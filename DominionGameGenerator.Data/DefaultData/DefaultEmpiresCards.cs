using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultEmpiresCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                #region Empires (#253)
                
                new Card
                {
                    ID = 178,
                    Name = "Advance",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 179,
                    Name = "Annex",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 8,
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
                    ID = 180,
                    Name = "Aqueduct",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 181,
                    Name = "Archive",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 182,
                    Name = "Arena",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 183,
                    Name = "Bandit Fort",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 184,
                    Name = "Banquet",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 185,
                    Name = "Basilica",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 186,
                    Name = "Baths",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 187,
                    Name = "Battlefield",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 188,
                    Name = "Bustling Village",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 189,
                    Name = "Capital",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 190,
                    Name = "Castles",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 191,
                    Name = "Catapult",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 192,
                    Name = "Catapult/Rocks",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 193,
                    Name = "Chariot Race",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 194,
                    Name = "Charm",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 195,
                    Name = "City Quarter",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 8,
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
                    ID = 196,
                    Name = "Colonnade",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 197,
                    Name = "Conquest",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 198,
                    Name = "Crown",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.TREASURE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 199,
                    Name = "Crumbling Castle",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 200,
                    Name = "Defiled Shrine",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 201,
                    Name = "Delve",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 202,
                    Name = "Dominate",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 14,
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
                    ID = 203,
                    Name = "Donate",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 8,
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
                    ID = 204,
                    Name = "Emporium",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 205,
                    Name = "Encampment",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 206,
                    Name = "Encampment/Plunder",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 207,
                    Name = "Enchantress",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 3,
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
                    ID = 208,
                    Name = "Engineer",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 4,
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
                    ID = 209,
                    Name = "Farmer's Market",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.GATHERING_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 210,
                    Name = "Fortune",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 8,
                    PotionCost = 0,
                    DebtTokenCost = 8,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 211,
                    Name = "Forum",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 212,
                    Name = "Fountain",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 213,
                    Name = "Gladiator",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 214,
                    Name = "Gladiator/Fortune",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 215,
                    Name = "Grand Castle",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 9,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 216,
                    Name = "Groundskeeper",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 217,
                    Name = "Haunted Castle",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 218,
                    Name = "Humble Castle",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 219,
                    Name = "Keep",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 220,
                    Name = "King's Castle",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 10,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 221,
                    Name = "Labyrinth",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 222,
                    Name = "Legionary",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 223,
                    Name = "Mountain Pass",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 224,
                    Name = "Museum",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 225,
                    Name = "Obelisk",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 226,
                    Name = "Opulent Castle",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 7,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 227,
                    Name = "Orchard",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 228,
                    Name = "Overlord",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 8,
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
                    ID = 229,
                    Name = "Palace",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 230,
                    Name = "Patrician",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 231,
                    Name = "Patrician/Emporium",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 232,
                    Name = "Plunder",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 233,
                    Name = "Ritual",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 234,
                    Name = "Rocks",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 235,
                    Name = "Royal Blacksmith",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 8,
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
                    ID = 236,
                    Name = "Sacrifice",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 237,
                    Name = "Salt the Earth",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.EVENT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 238,
                    Name = "Settlers",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 239,
                    Name = "Settlers/Bustling Village",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 240,
                    Name = "Small Castle",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 241,
                    Name = "Sprawling Castle",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 8,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.CASTLE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 242,
                    Name = "Tax",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 243,
                    Name = "Temple",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.GATHERING_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 244,
                    Name = "Tomb",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 245,
                    Name = "Tower",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_TYPE]
                    }
                },
                new Card
                {
                    ID = 246,
                    Name = "Triumph",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 5,
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
                    ID = 247,
                    Name = "Triumphal Arch",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 248,
                    Name = "Villa",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 249,
                    Name = "Wall",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 250,
                    Name = "Wedding",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 3,
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
                    ID = 251,
                    Name = "Wild Hunt",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.GATHERING_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 252,
                    Name = "Windfall",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
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
                    ID = 253,
                    Name = "Wolf Den",
                    ExpansionID = expansionDict[Constants.EMPIRES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.EMPIRES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.LANDMARK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.EVENT_CATEGORY]
                    }
                },

                #endregion Empires (#253)
            };
        }
    }
}
