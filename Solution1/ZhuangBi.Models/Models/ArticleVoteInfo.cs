using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class ArticleVoteInfo
    {
        public int id
        {
            get; set;
        }

        public int uid
        {
            get; set;
        }

        public string type
        {
            get; set;
        }

        public int item_id
        {
            get; set;
        }

        public int rating
        {
            get; set;
        }

        public long time
        {
            get; set;
        }

        public int reputation_factor
        {
            get; set;
        }

        public int item_uid
        {
            get; set;
        }
    }
}