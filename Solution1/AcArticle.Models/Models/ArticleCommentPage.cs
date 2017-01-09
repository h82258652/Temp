using AcArticle.Models.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AcArticle.Models
{
    [JsonObject]
    public class ArticleCommentPage
    {
        [JsonConverter(typeof(IntegerConverter))]
        [JsonProperty("totalCount")]
        public int TotalCount
        {
            get;
            set;
        }

        [JsonConverter(typeof(IntegerConverter))]
        [JsonProperty("pageSize")]
        public int PageSize
        {
            get;
            set;
        }

        [JsonConverter(typeof(IntegerConverter))]
        [JsonProperty("pageNo")]
        public int PageNo
        {
            get;
            set;
        }

        [JsonProperty("list")]
        public string[] List
        {
            get;
            set;
        }

        [JsonProperty("map")]
        public Dictionary<string, ArticleComment> Map
        {
            get;
            set;
        }
    }
}