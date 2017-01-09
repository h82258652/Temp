using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class LoginResult
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
        /// 头像地址
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar
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

        /// <summary>
        /// 是否首次登录，1:是，0:否
        /// </summary>
        [JsonProperty("is_first_login")]
        public int IsFirstLogin
        {
            get;
            set;
        }
    }
}