using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DominionGameGenerator.Data.DefaultData
{
    public class DefaultExpansions
    {
        private static IEnumerable<Expansion> _expansions;
        public static IEnumerable<Expansion> Expansions
        {
            get
            {
                if (_expansions == null)
                {
                    InitCardCategories();
                }

                return _expansions;
            }
        }

        public static Dictionary<string, Expansion> ExpansionDictionary
        {
            get
            {
                return Expansions.ToDictionary(x => x.Name);
            }
        }

        private static void InitCardCategories()
        {
            string[] expansionNames = new string[]
            {
                Constants.ADVENTURES_EXPANSION,
                Constants.ALCHEMY_EXPANSION,
                Constants.CORNUCOPIA_EXPANSION,
                Constants.DARK_AGES_EXPANSION,
                Constants.DOMINION_EXPANSION,
                Constants.EMPIRES_EXPANSION,
                Constants.GUILDS_EXPANSION,
                Constants.HINTERLANDS_EXPANSION,
                Constants.INTRIGUE_EXPANSION,
                Constants.NOCTURNE_EXPANSION,
                Constants.PROSPERITY_EXPANSION,
                Constants.SEASIDE_EXPANSION
            };

            List<Expansion> newExpansions = new List<Expansion>();
            int id = 1;

            foreach (var name in expansionNames)
            {
                newExpansions.Add(new Expansion
                {
                    ID = id,
                    Name = name
                });
                id++;
            }

            _expansions = newExpansions;
        }
    }
}
