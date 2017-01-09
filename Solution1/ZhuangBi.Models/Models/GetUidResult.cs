using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class GetUidResult
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        [JsonProperty("uid")]
        public int Uid
        {
            get;
            set;
        }
    }
}