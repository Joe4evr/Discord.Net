﻿using Newtonsoft.Json;

namespace Discord.API.Rpc
{
    public class GetChannelParams
    {
        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }
    }
}
