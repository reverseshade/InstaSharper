﻿using Newtonsoft.Json;

namespace InstaSharper.ResponseWrappers.BaseResponse
{
    public class BaseLoadableResponse : BaseStatusResponse
    {
        [JsonProperty("more_available")]
        public bool MoreAvailable { get; set; }

        [JsonProperty("num_results")]
        public int ResultsCount { get; set; }

        [JsonProperty("auto_load_more_enabled")]
        public bool AutoLoadMoreEnabled { get; set; }

        [JsonProperty("next_max_id")]
        public string NextMaxId { get; set; }
    }
}