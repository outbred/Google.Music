﻿using GoogleMusicApi.Requests.Data;

namespace GoogleMusicApi.Requests
{
    public class ListListenNowTracks : StructuredRequest<GetRequest, ListListenNowTracksResponse>
    {
        public override string RelativeRequestUrl => "listennow/getlistennowitems";
    }
}