using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultNocturneCards
    {
        public static IEnumerable<Card> GetDefaultCards(Dictionary<string, Expansion> expansionDict, Dictionary<string, CardType> typeDict, Dictionary<string, CardCategory> categoryDict)
        {
            var boonCard = new Card
            {
                ID = 421,
                Name = "Boon Cards",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 0,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.BOON_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var hexCard = new Card
            {
                ID = 421,
                Name = "Hex Cards",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 0,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.HEX_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var lostInWoodsCard = new Card
            {
                ID = 420,
                Name = "Lost In Woods",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 0,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.STATE_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var pouchCard = new Card
            {
                ID = 414,
                Name = "Pouch",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 2,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.HIERLOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var trackerCard = new Card
            {
                ID = 401,
                Name = "Tracker",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 5,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.FATE_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    },
                DependentCards = new Card[]
                {
                    pouchCard
                }
            };

            var pastureCard = new Card
            {
                ID = 413,
                Name = "Pasture",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 2,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.VICTORY_TYPE],
                        typeDict[Constants.HIERLOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var shepherdCard = new Card
            {
                ID = 398,
                Name = "Shepherd",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
                    },
                DependentCards = new Card[]
                {
                    pastureCard
                }
            };

            var magicLampCard = new Card
            {
                ID = 412,
                Name = "Magic Lamp",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 0,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.HIERLOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var goatCard = new Card
            {
                ID = 408,
                Name = "Goat",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 2,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.HIERLOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var pixieCard = new Card
            {
                ID = 393,
                Name = "Pixie",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 2,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.FATE_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    },
                DependentCards = new Card[]
                {
                    goatCard
                }
            };

            var luckyCoinCard = new Card
            {
                ID = 411,
                Name = "Lucky Coin",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 4,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.HIERLOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var foolCard = new Card
            {
                ID = 385,
                Name = "Fool",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 3,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.FATE_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    },
                DependentCards = new Card[]
                {
                    luckyCoinCard,
                    lostInWoodsCard
                }
            };

            var hauntedMirrorCard = new Card
            {
                ID = 409,
                Name = "Haunted Mirror",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 0,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.HIERLOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var wishCard = new Card
            {
                ID = 416,
                Name = "Wish",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
            };

            var leprecahnCard = new Card
            {
                ID = 389,
                Name = "Leprechaun",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 3,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    },
                DependentCards = new Card[]
                {
                    wishCard
                }
            };

            var secretCaveCard = new Card
            {
                ID = 397,
                Name = "Secret Cave",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
                    },
                DependentCards = new Card[]
                {
                    wishCard,
                    magicLampCard
                }
            };

            var zombieApprentice = new Card
            {
                ID = 417,
                Name = "Zombie Apprentice",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 3,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ZOMBIE_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var zombieMason = new Card
            {
                ID = 418,
                Name = "Zombie Mason",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 3,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ZOMBIE_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var zombieSpy = new Card
            {
                ID = 419,
                Name = "Zombie Spy",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 3,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ZOMBIE_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var necromancerCard = new Card
            {
                ID = 391,
                Name = "Necromancer",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
                    },
                DependentCards = new Card[]
                {
                    zombieApprentice,
                    zombieMason,
                    zombieSpy
                }
            };

            var ghostCard = new Card
            {
                ID = 407,
                Name = "Ghost",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 4,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.DURATION_TYPE],
                        typeDict[Constants.SPIRIT_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var impCard = new Card
            {
                ID = 410,
                Name = "Imp",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 2,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.SPIRIT_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var willOWispCard = new Card
            {
                ID = 415,
                Name = "Will-o'-Wisp",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 0,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.SPIRIT_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var exorcistCard = new Card
            {
                ID = 383,
                Name = "Exorcist",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 4,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    },
                DependentCards = new Card[]
                {
                    ghostCard,
                    impCard,
                    willOWispCard
                }
            };

            var cursedGoldCard = new Card
            {
                ID = 406,
                Name = "Cursed Gold",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 5,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.HIERLOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var pookaCard = new Card
            {
                ID = 394,
                Name = "Pooka",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
                    },
                DependentCards = new Card[]
                {
                    cursedGoldCard
                }
            };

            var batCard = new Card
            {
                ID = 405,
                Name = "Bat",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 2,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.OTHER_CATEGORY]
                    }
            };

            var vampireCard = new Card
            {
                ID = 403,
                Name = "Vampire",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 5,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.DOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    },
                DependentCards = new Card[]
                {
                    batCard
                }
            };

            var devilsWorkshopCard = new Card
            {
                ID = 381,
                Name = "Devil's Workshop",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 4,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    },
                DependentCards = new Card[]
                {
                    impCard
                }
            };

            var tormentorCard = new Card
            {
                ID = 400,
                Name = "Tormentor",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                CoinCost = 5,
                PotionCost = 0,
                DebtTokenCost = 0,
                CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.DOOM_TYPE]
                    },
                CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    },
                DependentCards = new Card[]
                {
                    impCard
                }
            };

            var cemeteryCard = new Card
            {
                ID = 374,
                Name = "Cemetery",
                ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
                    },
                DependentCards = new Card[]
                {
                    ghostCard,
                    hauntedMirrorCard
                }
            };

            IEnumerable<Card> result = new List<Card>
            {

                #region Nocturne
                
                new Card
                {
                    ID = 372,
                    Name = "Bard",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.FATE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 373,
                    Name = "Blessed Village",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.FATE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                cemeteryCard,
                new Card
                {
                    ID = 375,
                    Name = "Changeling",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 376,
                    Name = "Cobbler",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 377,
                    Name = "Conclave",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
                    ID = 378,
                    Name = "Crypt",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 379,
                    Name = "Cursed Village",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.DOOM_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 380,
                    Name = "Den of Sin",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                devilsWorkshopCard,
                new Card
                {
                    ID = 382,
                    Name = "Druid",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.FATE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                exorcistCard,
                new Card
                {
                    ID = 384,
                    Name = "Faithful Hound",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
                foolCard,
                new Card
                {
                    ID = 386,
                    Name = "Ghost Town",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 387,
                    Name = "Guardian",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.DURATION_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 388,
                    Name = "Idol",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.TREASURE_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.FATE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                leprecahnCard,
                new Card
                {
                    ID = 390,
                    Name = "Monastery",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 2,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                exorcistCard,
                new Card
                {
                    ID = 392,
                    Name = "Night Watchman",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 3,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                pixieCard,
                pookaCard,
                new Card
                {
                    ID = 395,
                    Name = "Raider",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 6,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.DURATION_TYPE],
                        typeDict[Constants.ATTACK_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                new Card
                {
                    ID = 396,
                    Name = "Sacred Grove",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.FATE_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                secretCaveCard,
                shepherdCard,
                new Card
                {
                    ID = 399,
                    Name = "Skulk",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 4,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.DOOM_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                tormentorCard,
                trackerCard,
                new Card
                {
                    ID = 402,
                    Name = "Tragic Hero",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
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
                vampireCard,
                new Card
                {
                    ID = 404,
                    Name = "Werewolf",
                    ExpansionID = expansionDict[Constants.NOCTURNE_EXPANSION].ID,
                    Expansion = expansionDict[Constants.NOCTURNE_EXPANSION],
                    CoinCost = 5,
                    PotionCost = 0,
                    DebtTokenCost = 0,
                    CardTypes = new CardType[]
                    {
                        typeDict[Constants.ACTION_TYPE],
                        typeDict[Constants.NIGHT_TYPE],
                        typeDict[Constants.ATTACK_TYPE],
                        typeDict[Constants.DOOM_TYPE]
                    },
                    CardCategories = new CardCategory[]
                    {
                        categoryDict[Constants.KINGDOM_CATEGORY]
                    }
                },
                batCard,
                cursedGoldCard,
                ghostCard,
                goatCard,
                hauntedMirrorCard,
                impCard,
                luckyCoinCard,
                magicLampCard,
                pastureCard,
                pouchCard,
                willOWispCard,
                wishCard,
                zombieApprentice,
                zombieMason,
                zombieSpy,
                lostInWoodsCard,
                hexCard,
                boonCard

	            #endregion Nocturne
            };
            
            var doomType = typeDict[Constants.DOOM_TYPE];

            result = result.Select(x =>
            {
                if (x.CardTypes.Any(y => y.Name == Constants.FATE_TYPE))
                {
                    List<Card> cardList = new List<Card>();
                    if (x.DependentCards != null)
                    {
                        cardList.AddRange(x.DependentCards);
                    }
                    cardList.Add(boonCard);
                    x.DependentCards = cardList;
                }
                else if (x.CardTypes.Any(y => y.Name == Constants.DOOM_TYPE))
                {
                    List<Card> cardList = new List<Card>();
                    if (x.DependentCards != null)
                    {
                        cardList.AddRange(x.DependentCards);
                    }
                    cardList.Add(hexCard);
                    x.DependentCards = cardList;
                }

                return x;
            });

            return result;
        }
    }
}
