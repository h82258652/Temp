using Newtonsoft.Json;

namespace AcArticle.Models
{
    [JsonObject]
    public class ResultBase<T> : ResultBase
    {
        [JsonProperty("data")]
        public T Data
        {
            get;
            set;
        }
    }
}