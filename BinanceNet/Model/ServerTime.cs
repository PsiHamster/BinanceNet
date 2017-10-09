using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BinanceNet.Model {
    /// <summary>
    /// Class contains current server time
    /// </summary>
    [JsonObject (MemberSerialization.OptIn)]
    public class ServerTime {

        /// <summary>
        /// Current server time in UNIX millis
        /// </summary>
        [JsonProperty(PropertyName= "serverTime")]
        public static long CurrentServerTimeStamp { get; set; }
    }
}
