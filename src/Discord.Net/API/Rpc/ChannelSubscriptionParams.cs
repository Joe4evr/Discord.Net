﻿using Newtonsoft.Json;

namespace Discord.API.Rpc
{
    public class ChannelSubscriptionParams
    {
        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }
    }
}
