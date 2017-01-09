using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class AvatarUploadResult
    {
        /// <summary>
        /// 头像预览地址
        /// </summary>
        [JsonProperty("preview")]
        public string Preview
        {
            get;
            set;
        }
    }
}