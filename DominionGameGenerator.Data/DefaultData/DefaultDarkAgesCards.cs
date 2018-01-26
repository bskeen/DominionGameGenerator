using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultDarkAgesCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            return new List<Card>
            {
                #region Dark Ages (#144)

                new Card
                {
                    ID = 90,
                    Name = "Altar",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 91,
                    Name = "Armory",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 92,
                    Name = "Band of Misfits",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 93,
                    Name = "Bandit Camp",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 94,
                    Name = "Beggar",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 95,
                    Name = "Catacombs",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 96,
                    Name = "Count",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 97,
                    Name = "Cultist",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.LOOTER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 98,
                    Name = "Death Cart",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.LOOTER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 99,
                    Name = "Forager",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 100,
                    Name = "Fortress",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 101,
                    Name = "Grave Robber",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 102,
                    Name = "Hermit",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 103,
                    Name = "Hunting Grounds",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 104,
                    Name = "Ironmonger",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 105,
                    Name = "Junk Dealer",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 106,
                    Name = "Marauder",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.LOOTER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 107,
                    Name = "Market Square",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 108,
                    Name = "Mystic",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 109,
                    Name = "Pillage",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 110,
                    Name = "Poor House",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 1,
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
                    ID = 111,
                    Name = "Procession",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 112,
                    Name = "Rebuild",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 113,
                    Name = "Rogue",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 114,
                    Name = "Sage",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 115,
                    Name = "Scavenger",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 116,
                    Name = "Squire",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 117,
                    Name = "Urchin",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 118,
                    Name = "Vagrant",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 119,
                    Name = "Wandering Minstrel",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 120,
                    Name = "Counterfeit",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 121,
                    Name = "Feodum",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 4,
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
                    ID = 122,
                    Name = "Rats",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 123,
                    Name = "Knights",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 124,
                    Name = "Dame Anna",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 125,
                    Name = "Dame Josephine",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE],
                        typeDict[Constants.VICTORY_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 126,
                    Name = "Dame Molly",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 127,
                    Name = "Dame Natalie",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 128,
                    Name = "Dame Sylvia",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 129,
                    Name = "Sir Bailey",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 130,
                    Name = "Sir Destry",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 131,
                    Name = "Sir Martin",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 132,
                    Name = "Sir Michael",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 133,
                    Name = "Sir Vander",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.KNIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 134,
                    Name = "Abandoned Mine",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RUINS_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 135,
                    Name = "Ruined Library",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RUINS_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 136,
                    Name = "Ruined Market",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RUINS_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 137,
                    Name = "Ruined Village",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RUINS_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 138,
                    Name = "Survivors",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 0,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.RUINS_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 139,
                    Name = "Hovel",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 1,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.REACTION_TYPE],
                        typeDict[Constants.SHELTER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 140,
                    Name = "Necropolis",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 1,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.SHELTER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 141,
                    Name = "Overgrown Estate",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 1,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.SHELTER_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 142,
                    Name = "Spoils",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 0,
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
                    ID = 143,
                    Name = "Madman",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
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
                    ID = 144,
                    Name = "Mercenary",
                    ExpansionID = expansionDict[Constants.DARK_AGES_EXPANSION].ID,
                    Expansion = expansionDict[Constants.DARK_AGES_EXPANSION],
                    CoinCost = 0,
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

                #endregion Dark Ages (#144)
            };
        }
    }
}
