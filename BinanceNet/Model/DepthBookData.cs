using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BinanceNet.Model {
    /// <summary>
    /// Class contains Data of Depth Book
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DepthBookData {
        /// <summary>
        /// Id of last update
        /// </summary>
        [JsonProperty("lastUpdateId")]
        public long LastUpdateId { get; set; }

        /// <summary>
        /// All bids in depth book.
        /// </summary>
        [JsonProperty (PropertyName = "b")]
        public DepthBookOrderEntry[] Bids { get; private set; }

        /// <summary>
        /// All asks in depth book.
        /// </summary>
        [JsonProperty (PropertyName = "a")]
        public DepthBookOrderEntry[] Asks { get; private set; }
    }
}
