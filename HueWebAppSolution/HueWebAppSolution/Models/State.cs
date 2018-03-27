using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HueWebAppSolution.Models
{
    public class State
    {
        [JsonProperty(PropertyName = "on")]
        public bool On { get; set; }
        [JsonProperty(PropertyName = "bri")]
        public int Bri { get; set; }
        [JsonProperty(PropertyName = "hue")]
        public int Hue { get; set; }
        [JsonProperty(PropertyName = "sat")]
        public int Sat { get; set; }
        [JsonProperty(PropertyName = "xy")]
        public decimal[] Xy { get; set; }
        [JsonProperty(PropertyName = "ct")]
        public int Ct { get; set; }
        [JsonProperty(PropertyName = "alert")]
        public string Alert { get; set; }
        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }
        [JsonProperty(PropertyName = "colormode")]
        public string ColorMode { get; set; }
        [JsonProperty(PropertyName = "reachable")]
        public bool Reachable { get; set; }
    }
}