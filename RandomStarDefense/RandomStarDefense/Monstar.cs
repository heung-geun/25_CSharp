using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStarDefense
{
    internal class Monstar
    {
        [JsonProperty("Lable")]
        public string Lable { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Hp")]
        public int Hp { get; set; }

        [JsonProperty("Shield")]
        public int Shield { get; set; }

        [JsonProperty("Speed")]
        public int Speed { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }


    }
}
