using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class QuestionInfo
    {
        [JsonProperty("question_id")]
        public int QuestionId
        {
            get;
            set;
        }

        [JsonProperty("question_content")]
        public string QuestionContent
        {
            get;
            set;
        }

        [JsonProperty("question_detail")]
        public string QuestionDetail
        {
            get;
            set;
        }

        [JsonProperty("add_time")]
        public long AddTime
        {
            get;
            set;
        }

        [JsonProperty("update_time")]
        public long UpdateTime
        {
            get;
            set;
        }

        [JsonProperty("answer_count")]
        public int AnswerCount
        {
            get;
            set;
        }

        [JsonProperty("view_count")]
        public int ViewCount
        {
            get;
            set;
        }

        [JsonProperty("focus_count")]
        public int FocusCount
        {
            get;
            set;
        }
    }
}