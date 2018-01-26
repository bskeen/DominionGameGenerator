using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Services.DataTransferObjects
{
    public class CardDto
    {
        public string Name { get; set; }
        public string ExpansionName { get; set; }
        public IEnumerable<string> Types { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<CardDto> DependentCards { get; set; } = new CardDto[0];
    }
}
