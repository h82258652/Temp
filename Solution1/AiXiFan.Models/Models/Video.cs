using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class Video
    {
        [JsonProperty("allowDanmaku")]
        public int AllowDanmaku
        {
            get;
            set;
        }

        [JsonProperty("commentId")]
        public int CommentId
        {
            get;
            set;
        }

        [JsonProperty("danmakuId")]
        public int DanmakuId
        {
            get;
            set;
        }

        [JsonProperty("sourceId")]
        public string SourceId
        {
            get;
            set;
        }

        [JsonProperty("sourceType")]
        public string SourceType
        {
            get;
            set;
        }

        [JsonProperty("startTime")]
        public int StartTime
        {
            get;
            set;
        }

        [JsonProperty("time")]
        public int Time
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

        [JsonProperty("videoId")]
        public int VideoId
        {
            get;
            set;
        }

        [JsonProperty("visibleLevel")]
        public int VisibleLevel
        {
            get;
            set;
        }
    }
}