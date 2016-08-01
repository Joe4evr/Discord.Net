﻿using Newtonsoft.Json;

namespace Discord.API
{
    public class IntegrationAccount
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
