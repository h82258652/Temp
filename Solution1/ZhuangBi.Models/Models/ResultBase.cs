using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class ResultBase
    {
        [JsonProperty("errno")]
        public int ErrorCode
        {
            get;
            set;
        }

        [JsonProperty("err")]
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}