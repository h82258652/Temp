using Newtonsoft.Json;

namespace ZhuangBi.Models.Interfaces
{
    [JsonObject]
    public interface IAddTime
    {
        [JsonProperty("add_time")]
        long AddTime
        {
            get;
            set;
        }
    }
}