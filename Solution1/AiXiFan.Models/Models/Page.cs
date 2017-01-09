using Newtonsoft.Json;
using System.Collections.Generic;

namespace AiXiFan.Models
{
    [JsonObject]
    public class Page
    {
        [JsonProperty("totalCount")]
        public int TotalCount
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

        [JsonProperty("pageNo")]
        public int PageNo
        {
            get;
            set;
        }

        [JsonProperty("list")]
        public int[] List
        {
            get;
            set;
        }

        [JsonProperty("map")]
        public Dictionary<int, Comment> Map
        {
            get;
            set;
        }
    }
}