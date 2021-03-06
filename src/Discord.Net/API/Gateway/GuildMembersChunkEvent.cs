﻿using Newtonsoft.Json;

namespace Discord.API.Gateway
{
    public class GuildMembersChunkEvent
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }
        [JsonProperty("members")]
        public GuildMember[] Members { get; set; }
    }
}
