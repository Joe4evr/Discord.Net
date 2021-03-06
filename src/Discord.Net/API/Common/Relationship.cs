﻿using Newtonsoft.Json;

namespace Discord.API
{
    public class Relationship
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("type")]
        public RelationshipType Type { get; set; }
    }
}
