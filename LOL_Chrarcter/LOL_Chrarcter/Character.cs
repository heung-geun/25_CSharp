using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL_Chrarcter
{
    internal class Character
    {
        [JsonProperty("Lable")]
        public int Label { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Role_1")]
        public string Role_1 { get; set; }
        [JsonProperty("Role_2")]
        public string Role_2 { get; set; }
        [JsonProperty("Passive")]
        public string Passive { get; set; }
        [JsonProperty("SkIll_Q")]
        public string SkIll_Q { get; set; }
        [JsonProperty("SkIll_W")]
        public string SkIll_w { get; set; }
        [JsonProperty("SkIll_E")]
        public string SkIll_E { get; set; }
        [JsonProperty("SkIll_R")]
        public string SkIll_R { get; set; }
        [JsonProperty("Skin")]
        public int Skin { get; set; }
    }
}
