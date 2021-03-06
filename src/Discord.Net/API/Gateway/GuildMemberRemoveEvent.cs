﻿using Newtonsoft.Json;

namespace Discord.API.Gateway
{
    public class GuildMemberRemoveEvent
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
