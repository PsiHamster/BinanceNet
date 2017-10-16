using System;
using Newtonsoft.Json;

namespace BinanceNet.Model.General {
    /// <summary>
    /// Class contains current server time
    /// </summary>
    [JsonObject (MemberSerialization.OptIn)]
    public class ServerTime {

        /// <summary>
        /// Current server time
        /// </summary>
        [JsonProperty(PropertyName= "serverTime")]
        public static DateTimeOffset CurrentServerTimeStamp { get; set; }
    }
}
