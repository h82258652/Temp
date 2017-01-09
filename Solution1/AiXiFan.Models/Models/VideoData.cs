﻿using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class VideoData : DataBase
    {
        [JsonProperty("contentId")]
        public int ContentId
        {
            get;
            set;
        }

        [JsonProperty("display")]
        public int Display
        {
            get;
            set;
        }

        [JsonProperty("isComment")]
        public bool IsComment
        {
            get;
            set;
        }

        [JsonProperty("owner")]
        public Owner Owner
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public int Status
        {
            get;
            set;
        }

        [JsonProperty("updatedAt")]
        public long UpdatedAt
        {
            get;
            set;
        }

        [JsonProperty("videoCount")]
        public int VideoCount
        {
            get;
            set;
        }

        [JsonProperty("videos")]
        public Video[] Videos
        {
            get;
            set;
        }
    }
}