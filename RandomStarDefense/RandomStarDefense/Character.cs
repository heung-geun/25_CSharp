using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStarDefense
{
    internal class Character
    {
        [JsonProperty("Lable")]
        public string Lable { get; set; }

        [JsonProperty("Trive")]
        public string Trive { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Damage")]
        public int Damage { get; set; }

        [JsonProperty("AttackSpeed")]
        public float AttackSpeed { get; set; }

        [JsonProperty("AttackRange")]
        public int AttackRange { get; set; }

        [JsonProperty("BossAddDamage")]
        public float BossAddDamage { get; set; }

        [JsonProperty("AttackType")]
        public string AttackType { get; set; }

        [JsonProperty("AttackRangeType")]
        public string AttackRangeType { get; set; }
      
    }
}
