using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class ResultBase<T> : ResultBase
    {
        [JsonProperty("rsm")]
        public T Data
        {
            get;
            set;
        }
    }
}