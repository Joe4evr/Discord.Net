﻿using Newtonsoft.Json;

namespace Discord.API.Rpc
{
    public class ReadyEvent
    {
        [JsonProperty("v")]
        public int Version { get; set; }
        [JsonProperty("config")]
        public RpcConfig Config { get; set; }
    }
}
