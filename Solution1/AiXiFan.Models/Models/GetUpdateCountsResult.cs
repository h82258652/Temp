using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class GetUpdateCountsResult : ResultBase<GetUpdateCountsData>
    {
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
    }
}