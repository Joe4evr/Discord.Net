﻿using Newtonsoft.Json;
using System;

namespace Discord.API
{
    public class GuildMember
    {
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("nick")]
        public Optional<string> Nick { get; set; }
        [JsonProperty("roles")]
        public ulong[] Roles { get; set; }
        [JsonProperty("joined_at")]
        public DateTimeOffset JoinedAt { get; set; }
        [JsonProperty("deaf")]
        public bool Deaf { get; set; }
        [JsonProperty("mute")]
        public bool Mute { get; set; }
    }
}
