﻿using GoogleMusicApi.Requests.Data;
using GoogleMusicApi.Structure;

namespace GoogleMusicApi.Requests
{
    public class ExecuteSearch : StructuredRequest<SearchGetRequest, SearchResponse>
    {
        public override string RelativeRequestUrl => "query";
    }
}