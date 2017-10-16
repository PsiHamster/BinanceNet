using System;
using BinanceNet.Utils;
using Newtonsoft.Json;

namespace BinanceNet.Model.General {
    // TODO: Documentation
    /// <summary>
    /// Contains stats of symbol in 24 hr.
    /// </summary>
    [JsonObject (MemberSerialization.OptIn)]
    public class Symbol24Stats {
        /// <summary>
        /// Price change since 24hr.
        /// </summary>
        [JsonProperty ("priceChange")]
        public decimal PriceChange { get; set; }

        /// <summary>
        /// Price change in %
        /// </summary>
        [JsonProperty ("priceChangePercent")]
        public decimal PriceChangePercent { get; set; }

        /// <summary>
        /// Average price
        /// </summary>
        [JsonProperty ("weightedAvgPrice")]
        public decimal WeightedAvgPrice { get; set; }

        [JsonProperty ("prevClosePrice")]
        public decimal PrevClosePrice { get; set; }

        [JsonProperty ("lastPrice")]
        public decimal LastPrice { get; set; }

        [JsonProperty ("bidPrice")]
        public decimal BidPrice { get; set; }

        [JsonProperty ("askPrice")]
        public decimal AskPrice { get; set; }

        [JsonProperty ("openPrice")]
        public decimal OpenPrice { get; set; }
        
        [JsonProperty ("highPrice")]
        public decimal HighPrice { get; set; }

        [JsonProperty ("lowPrice")]
        public decimal LowPrice { get; set; }

        [JsonProperty ("volume")]
        public decimal Volume { get; set; }

        [JsonProperty ("openTime")]
        public TimeStamp OpenTime { get; set; }

        [JsonProperty ("closeTime")]
        public TimeStamp CloseTime { get; set; }

        // TODO: CHECK FRIST OR FIRST, FRIST IN DOCUMENTATION 
        [JsonProperty ("fristId")]
        public long FirstId { get; set; }

        [JsonProperty ("lastId")]
        public long LastId { get; set; }

        [JsonProperty("count")]
        public long TradeCount { get; set; }
    }
}
