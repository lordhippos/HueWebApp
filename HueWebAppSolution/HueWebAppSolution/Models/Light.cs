using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HueWebAppSolution.Models
{
    public class Light
    {
        [JsonProperty(PropertyName = "state")]
        public State State { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "modelid")]
        public string ModelId { get; set; }
        [JsonProperty(PropertyName = "swversion")]
        public string SwVersion { get; set; }
    }
}