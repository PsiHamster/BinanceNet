using System;
using BinanceNet.Utils;
using Newtonsoft.Json;

namespace BinanceNet.Model.TradeHistory {
    /// <summary>
    /// Compressed, aggregated trade.
    /// </summary>
    [JsonObject (MemberSerialization.OptIn)]
    public struct AggregatedTrade {
        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty ("p")]
        public decimal Price { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty ("q")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Aggregate tradeID
        /// </summary>
        [JsonProperty ("a")]
        public long AggregateTradeId { get; set; }
        /// <summary>
        /// First id of trade that was aggregated here
        /// </summary>
        [JsonProperty ("f")]
        public long FirstTradeId { get; set; }
        /// <summary>
        /// Last id of trade that was aggregated here
        /// </summary>
        [JsonProperty ("l")]
        public long LastTradeId { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty ("T")]
        public TimeStamp TimeStamp { get; set; }

        /// <summary>
        /// If m = false, the trade was filled on a buy side order.
        /// (Maker is buyer).
        /// If m = true, the trade was filled on a sell side order.
        /// (Maker is seller).
        /// </summary>
        [JsonProperty ("m")]
        public bool IsBuyerMaker { get; set; }

        /// <summary>
        /// Was the trade the best price match?
        /// </summary>
        [JsonProperty ("M")]
        public bool WasTheTradeBestPrice { get; set; }
    }
}
