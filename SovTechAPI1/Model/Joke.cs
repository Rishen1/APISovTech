using Newtonsoft.Json;
using System;

namespace SovTechAPI1.Model
{
    public class Joke
    {

        [JsonProperty("created_at")]
        public DateTime created_at { get; set; }
        [JsonProperty("icon_url")]
        public string icon_url { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("updated_at")]
        public DateTime updated_at { get; set; }

       [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
       public string API { get; set; }
    }
}
