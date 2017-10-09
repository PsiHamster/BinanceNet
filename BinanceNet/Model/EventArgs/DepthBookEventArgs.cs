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
        public OrderEntry[] Bids { get; private set; }

        /// <summary>
        /// All asks in depth book.
        /// </summary>
        public OrderEntry[] Asks { get; private set; }

        /// <summary>
        /// SPECIAL FOR NEWTONSOFT.JSON
        /// YOU NEED TO USE <see cref="Bids"/> for it
        /// </summary>
        [JsonProperty (PropertyName = "b")]
        public decimal[][] DecimalBids {
            get { return Bids.Select (x => new[] { x.Price, x.Quantity }).ToArray (); }
            set { Bids = value.Select (x => new OrderEntry (x)).ToArray (); }
        }

        /// <summary>
        /// SPECIAL FOR NEWTONSOFT.JSON
        /// YOU NEED TO USE <see cref="Asks"/> for it
        /// </summary>
        [JsonProperty (PropertyName = "a")]
        public decimal[][] DecimalAsks {
            get { return Asks.Select (x => new[] { x.Price, x.Quantity }).ToArray (); }
            set { Asks = value.Select (x => new OrderEntry (x)).ToArray (); }
        }
    }
}
