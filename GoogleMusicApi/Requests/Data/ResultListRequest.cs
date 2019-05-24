﻿using GoogleMusicApi.Sessions;
using Newtonsoft.Json;

namespace GoogleMusicApi.Requests.Data
{
    
    [JsonObject(MemberSerialization.OptIn)]
    public class ResultListRequest : PostRequest
    {
        public ResultListRequest(Session session) : base(session)
        {
            MaxResults = 1000;
        }

        [JsonProperty("start-token")]
        public string StartToken { get; set; }

        [JsonProperty("max-results")]
        public int MaxResults { get; set; }
    }
}