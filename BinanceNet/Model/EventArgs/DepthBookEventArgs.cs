using System.Linq;
using Newtonsoft.Json;

namespace BinanceNet.Model.EventArgs {
    [JsonObject (MemberSerialization.OptIn)]
    public class DepthBookEventArgs {
        /// <summary>
        /// Event type (Normally need to be equal "depthUpdate")
        /// </summary>
        [JsonProperty (PropertyName = "e")]
        public string EventType { get; set; }

        /// <summary>
        /// Time of event in Unix millis timestamp
        /// </summary>
        [JsonProperty (PropertyName = "E")]
        public long EventTime { get; set; }

        /// <summary>
        /// String contains name of trading pair e.g. BNBBTC
        /// </summary>
        [JsonProperty (PropertyName = "s")]
        public string Symbol { get; set; }

        /// <summary>
        /// Update ID to sync up Depth Book
        /// </summary>
        [JsonProperty (PropertyName = "u")]
        public long UpdateId { get; set; }

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
