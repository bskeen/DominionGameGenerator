using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DominionGameGenerator.Data.DefaultData
{
    public static class DefaultCardTypes
    {
        private static IEnumerable<CardType> _cardTypes;
        public static IEnumerable<CardType> CardTypes
        {
            get
            {
                if (_cardTypes == null)
                {
                    InitCardCategories();
                }

                return _cardTypes;
            }
        }

        public static Dictionary<string, CardType> CardTypeDictionary
        {
            get
            {
                return CardTypes.ToDictionary(x => x.Name);
            }
        }

        private static void InitCardCategories()
        {
            string[] cardTypeNames = new string[]
            {
                Constants.ACTION_TYPE,
                Constants.ATTACK_TYPE,
                Constants.BOON_TYPE,
                Constants.CASTLE_TYPE,
                Constants.CURSE_TYPE,
                Constants.DOOM_TYPE,
                Constants.DURATION_TYPE,
                Constants.EVENT_TYPE,
                Constants.FATE_TYPE,
                Constants.GATHERING_TYPE,
                Constants.HEX_TYPE,
                Constants.HIERLOOM_TYPE,
                Constants.KNIGHT_TYPE,
                Constants.LANDMARK_TYPE,
                Constants.LOOTER_TYPE,
                Constants.NIGHT_TYPE,
                Constants.PRIZE_TYPE,
                Constants.REACTION_TYPE,
                Constants.RESERVE_TYPE,
                Constants.RUINS_TYPE,
                Constants.SHELTER_TYPE,
                Constants.SPIRIT_TYPE,
                Constants.STATE_TYPE,
                Constants.TRAVELLER_TYPE,
                Constants.TREASURE_TYPE,
                Constants.VICTORY_TYPE,
                Constants.ZOMBIE_TYPE
            };

            var cardTypes = new List<CardType>();
            int id = 1;

            foreach (string name in cardTypeNames)
            {
                cardTypes.Add(new CardType
                {
                    ID = id,
                    Name = name
                });
                id++;
            }

            _cardTypes = cardTypes;
        }
    }
}
