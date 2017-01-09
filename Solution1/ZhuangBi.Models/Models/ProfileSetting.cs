using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class ProfileSetting
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// 性别，1:男 2:女 3:保密
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public Gender? Gender
        {
            get;
            set;
        }

        /// <summary>
        /// 生日年份
        /// </summary>
        [JsonProperty("birthday_y", NullValueHandling = NullValueHandling.Ignore)]
        public int? BirthdayYear
        {
            get;
            set;
        }

        /// <summary>
        /// 生日月份
        /// </summary>
        [JsonProperty("birthday_m", NullValueHandling = NullValueHandling.Ignore)]
        public int? BirthdayMonth
        {
            get;
            set;
        }

        /// <summary>
        /// 生日日期
        /// </summary>
        [JsonProperty("birthday_d", NullValueHandling = NullValueHandling.Ignore)]
        public int? BirthdayDay
        {
            get;
            set;
        }

        /// <summary>
        /// 省份，如：浙江省
        /// </summary>
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province
        {
            get;
            set;
        }

        /// <summary>
        /// 城市，如：杭州市
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// 职业编号，参加： 获取职业(职位)列表
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobId
        {
            get;
            set;
        }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature
        {
            get;
            set;
        }

        /// <summary>
        /// 联系方式，QQ
        /// </summary>
        [JsonProperty("qq", NullValueHandling = NullValueHandling.Ignore)]
        public int? QQ
        {
            get;
            set;
        }

        /// <summary>
        /// 联系方式，手机
        /// </summary>
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile
        {
            get;
            set;
        }

        /// <summary>
        /// 联系方式，常用邮箱
        /// </summary>
        [JsonProperty("common_email", NullValueHandling = NullValueHandling.Ignore)]
        public string CommonEmail
        {
            get;
            set;
        }

        /// <summary>
        /// 联系方式，网站
        /// </summary>
        [JsonProperty("homepage", NullValueHandling = NullValueHandling.Ignore)]
        public string HomePage
        {
            get;
            set;
        }
    }
}