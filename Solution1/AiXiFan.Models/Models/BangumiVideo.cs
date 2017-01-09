using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class BangumiVideo
    {
        [JsonProperty("bangumiId")]
        public int BangumiId
        {
            get;
            set;
        }

        [JsonProperty("sort")]
        public int Sort
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

        [JsonProperty("updateTime")]
        public long UpdateTime
        {
            get;
            set;
        }

        [JsonProperty("videoId")]
        public int VideoId
        {
            get;
            set;
        }
    }
}