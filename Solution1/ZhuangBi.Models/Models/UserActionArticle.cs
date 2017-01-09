using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class UserActionArticle
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get; set;
        }

        public string message
        {
            get; set;
        }

        public int comments
        {
            get; set;
        }

        public int views
        {
            get; set;
        }

        public long add_time
        {
            get; set;
        }
    }
}