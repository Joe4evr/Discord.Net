﻿using Newtonsoft.Json;

namespace Discord.API
{
    public class InviteGuild
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("splash_hash")]
        public string SplashHash { get; set; }
    }
}
