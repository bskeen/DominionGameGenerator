using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Services.DataTransferObjects
{
    public class GameDto
    {
        public IEnumerable<CardDto> Cards { get; set; }
        public IEnumerable<CardDto> Events { get; set; }
        public IEnumerable<CardDto> Landmarks { get; set; }
        public bool IncludeProsperityExpandedCards { get; set; }
        public bool IncludeDarkAgesShelters { get; set; }
    }
}
