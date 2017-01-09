using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class ArticleCommentUserInfo
    {
        public int uid
        {
            get; set;
        }

        public string user_name
        {
            get; set;
        }

        public string signature
        {
            get; set;
        }

        public string avatar_file
        {
            get; set;
        }
    }
}