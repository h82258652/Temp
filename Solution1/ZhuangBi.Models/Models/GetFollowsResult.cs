using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class GetFollowsResult
    {
        [JsonProperty("total_rows")]
        public int TotalRows
        {
            get;
            set;
        }

        [JsonProperty("rows")]
        public FollowRow[] Rows
        {
            get;
            set;
        }
    }
}