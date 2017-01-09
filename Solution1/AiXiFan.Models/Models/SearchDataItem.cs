using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class SearchDataItem : DataBase
    {
        [JsonProperty("comments")]
        public int Comments
        {
            get;
            set;
        }

        [JsonProperty("contentId")]
        public string ContentId
        {
            get;
            set;
        }

        [JsonProperty("stows")]
        public int Stows
        {
            get;
            set;
        }

        [JsonProperty("tags")]
        public string[] Tags
        {
            get;
            set;
        }

        [JsonProperty("user")]
        public User User
        {
            get;
            set;
        }

        [JsonProperty("views")]
        public int Views
        {
            get;
            set;
        }
    }
}