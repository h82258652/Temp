using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZhuangBi.Models
{
    [JsonObject]
    public class GetUserActionsArticleResult
    {
        [JsonProperty("total_rows")]
        public int total_rows
        {
            get; set;
        }

        public doge[] rows
        {
            get; set;
        }
    }
}