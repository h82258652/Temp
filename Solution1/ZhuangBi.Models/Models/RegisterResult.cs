using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class RegisterResult
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        [JsonProperty("uid")]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 邮箱是否已验证，1:是，0:否
        /// </summary>
        [JsonProperty("valid_email")]
        public int ValidEmail
        {
            get;
            set;
        }
    }
}