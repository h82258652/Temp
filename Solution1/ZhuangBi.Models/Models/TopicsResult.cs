using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class TopicsResult
    {
        [JsonProperty("total_rows")]
        public int TotalRows
        {
            get;
            set;
        }

        [JsonProperty("rows")]
        public Topic[] Rows
        {
            get;
            set;
        }
    }
}