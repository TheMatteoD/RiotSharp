﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RiotSharp
{
    public class League : Thing
    {
        public League(JToken json)
        {
            JsonConvert.PopulateObject(json.ToString(), this, RiotApi.JsonSerializerSettings);
        }

        [JsonProperty("entries")]
        public List<LeagueItem> Entries { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("queue")]
        public String Queue { get; set; }
        [JsonProperty("tier")]
        public String Tier { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
