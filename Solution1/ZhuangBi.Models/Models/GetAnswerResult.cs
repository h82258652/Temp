using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class GetAnswerResult
    {
        [JsonProperty("answer")]
        public Answer Answer
        {
            get;
            set;
        }
    }
}