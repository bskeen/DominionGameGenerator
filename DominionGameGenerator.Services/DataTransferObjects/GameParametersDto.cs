using System;
using System.Collections.Generic;
using System.Text;
using DominionGameGenerator.Common.Enums;

namespace DominionGameGenerator.Services.DataTransferObjects
{
    public class GameParametersDto
    {
        public IEnumerable<int> ExpansionIDs { get; set; }

        public double ProsperityExpandedPercentage { get; set; }

        public double DarkAgesShelterPercentage { get; set; }

        public EventFrequencies EventFrequency { get; set; }
    }
}
