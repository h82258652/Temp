using Newtonsoft.Json;

namespace AiXiFan.Models
{
    [JsonObject]
    public class RegionData
    {
        [JsonProperty("belong")]
        public int Belong
        {
            get;
            set;
        }

        [JsonProperty("channelId")]
        public int ChannelId
        {
            get;
            set;
        }

        [JsonProperty("contentCount")]
        public int ContentCount
        {
            get;
            set;
        }

        [JsonProperty("contents")]
        public RegionContent[] Contents
        {
            get;
            set;
        }

        [JsonProperty("goText")]
        public string GoText
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

        [JsonProperty("image")]
        public string Image
        {
            get;
            set;
        }

        [JsonProperty("menuCount")]
        public int MenuCount
        {
            get;
            set;
        }

        [JsonProperty("menus")]
        public RegionMenu[] Menus
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

        [JsonProperty("platformId")]
        public int PlatformId
        {
            get;
            set;
        }

        [JsonProperty("showLine")]
        public int ShowLine
        {
            get;
            set;
        }

        [JsonProperty("showMore")]
        public int ShowMore
        {
            get;
            set;
        }

        [JsonProperty("showName")]
        public int ShowName
        {
            get;
            set;
        }

        [JsonProperty("sort")]
        public int Sort
        {
            get;
            set;
        }

        [JsonProperty("subTitle")]
        public string SubTitle
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public RegionType Type
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    }
}