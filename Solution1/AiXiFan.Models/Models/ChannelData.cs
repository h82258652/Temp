using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;

namespace AiXiFan.Models
{
    [JsonObject]
    public class ChannelData
    {
        [JsonProperty("childChannels")]
        public ChannelData[] ChildChannels
        {
            get;
            set;
        }

        [JsonProperty("configRegion")]
        public int ConfigRegion
        {
            get;
            set;
        }

        [JsonProperty("createDate")]
        public long CreateDate
        {
            get;
            set;
        }

        [JsonProperty("creator")]
        public int Creator
        {
            get;
            set;
        }

        [JsonProperty("dbstatus")]
        public int Dbstatus
        {
            get;
            set;
        }

        [JsonProperty("hide")]
        public int Hide
        {
            get;
            set;
        }

        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("img")]
        public string Img
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        private object[] _parents;

        [JsonProperty("parents")]
        public object[] Parents
        {
            get
            {
                return _parents;
            }
            set
            {
                // TODO
                if (value.Any())
                {
                    Debugger.Break();
                }
                _parents = value;
            }
        }

        [JsonProperty("pid")]
        public int Pid
        {
            get;
            set;
        }

        [JsonProperty("priority")]
        public int Priority
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public int Type
        {
            get;
            set;
        }

        [JsonProperty("updateDate")]
        public long UpdateDate
        {
            get;
            set;
        }

        [JsonProperty("updater")]
        public int Updater
        {
            get;
            set;
        }
    }
}