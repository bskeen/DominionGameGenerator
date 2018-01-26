using DominionGameGenerator.Data.DefaultData;
using DominionGameGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Data
{
    public class ExpansionRepository : IExpansionRepository
    {
        public IEnumerable<Expansion> GetExpansions()
        {
            return DefaultExpansions.Expansions;
        }
    }

    public interface IExpansionRepository
    {
        IEnumerable<Expansion> GetExpansions();
    }
}
