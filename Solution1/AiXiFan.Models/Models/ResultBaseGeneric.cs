using Newtonsoft.Json;

namespace AiXiFan.Models
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