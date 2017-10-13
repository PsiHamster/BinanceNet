using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BinanceNet.Model {
    /// <summary>
    /// Compressed, aggregated trade.
    /// </summary>
    [JsonObject (MemberSerialization.OptIn)]
    public class AggregatedTrade {
        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty ("p")]
        public decimal Price { get; }
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty ("q")]
        public decimal Quantity { get; }
        /// <summary>
        /// Aggregate tradeID
        /// </summary>
        [JsonProperty ("a")]
        public long AggregateTradeId { get; }
        /// <summary>
        /// First id of trade that was aggregated here
        /// </summary>
        [JsonProperty ("f")]
        public long FirstTradeId { get; }
        /// <summary>
        /// Last id of trade that was aggregated here
        /// </summary>
        [JsonProperty ("l")]
        public long LastTradeId { get; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty ("T")]
        public DateTimeOffset TimeStamp { get; }

        /// <summary>
        /// If m = false, the trade was filled on a buy side order.
        /// (Maker is buyer).
        /// If m = true, the trade was filled on a sell side order.
        /// (Maker is seller).
        /// </summary>
        [JsonProperty ("m")]
        public bool IsBuyerMaker { get; }

        /// <summary>
        /// Was the trade the best price match?
        /// </summary>
        [JsonProperty ("M")]
        public bool WasTheTradeBestPrice { get; }
    }
}
