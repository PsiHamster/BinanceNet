using System;
using BinanceNet.Utils;
using Newtonsoft.Json;

namespace BinanceNet.Model.DepthBook {
    [JsonObject (MemberSerialization.OptIn)]
    public class DepthBookUpdateArgs {
        /// <summary>
        /// Event type (Normally need to be equal "depthUpdate")
        /// </summary>
        [JsonProperty ("e")]
        public string EventType { get; set; }

        /// <summary>
        /// Time of event
        /// </summary>
        [JsonProperty ("E")]
        public TimeStamp EventTime { get; set; }

        /// <summary>
        /// String contains name of trading pair e.g. BNBBTC
        /// </summary>
        [JsonProperty ("s")]
        public string Symbol { get; set; }

        /// <summary>
        /// Update ID to sync up Depth Book
        /// </summary>
        [JsonProperty ("u")]
        public long UpdateId { get; set; }

        /// <summary>
        /// All bids in depth book.
        /// </summary>
        [JsonProperty ("b")]
        public DepthBookOrderEntry[] Bids { get; private set; }

        /// <summary>
        /// All asks in depth book.
        /// </summary>
        [JsonProperty ("a")]
        public DepthBookOrderEntry[] Asks { get; private set; }
    }
}
