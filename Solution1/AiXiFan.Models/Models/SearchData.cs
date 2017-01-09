using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class SearchData
    {
        [JsonProperty("pageNo")]
        public int PageNo
        {
            get;
            set;
        }

        [JsonProperty("pageSize")]
        public int PageSize
        {
            get;
            set;
        }

        [JsonProperty("totalCount")]
        public int TotalCount
        {
            get;
            set;
        }

        [JsonProperty("list")]
        public SearchDataItem[] List
        {
            get;
            set;
        }
    }
}