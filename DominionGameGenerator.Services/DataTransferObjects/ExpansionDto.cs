using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominionGameGenerator.Services.DataTransferObjects
{
    public class ExpansionDto
    {
        [JsonProperty("expansionID")]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}
