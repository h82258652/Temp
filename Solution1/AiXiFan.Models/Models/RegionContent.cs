using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class RegionContent
    {
        [JsonProperty("actionId")]
        public int ActionId
        {
            get;
            set;
        }

        [JsonProperty("channelId")]
        public int ChannelId
        {
            get;
            set;
        }

        [JsonProperty("hide")]
        public int Hide
        {
            get;
            set;
        }

        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("image")]
        public string Image
        {
            get;
            set;
        }

        [JsonProperty("intro")]
        public string Intro
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

        [JsonProperty("latestBangumiVideo")]
        public BangumiVideo LatestBangumiVideo
        {
            get;
            set;
        }

        [JsonProperty("regionId")]
        public int RegionId
        {
            get;
            set;
        }

        [JsonProperty("releaseDate")]
        public long ReleaseDate
        {
            get;
            set;
        }

        [JsonProperty("releasedAt")]
        public long ReleasedAt
        {
            get;
            set;
        }

        [JsonProperty("shareTagShow")]
        public int ShareTagShow
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

        [JsonProperty("subTitle")]
        public string SubTitle
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        [JsonProperty("visit")]
        public Visit Visit
        {
            get;
            set;
        }
    }
}