using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class QuestionTopic
    {
        [JsonProperty("topic_id")]
        public int TopicId
        {
            get;
            set;
        }

        [JsonProperty("topic_title")]
        public string TopicTitle
        {
            get;
            set;
        }
    }
}