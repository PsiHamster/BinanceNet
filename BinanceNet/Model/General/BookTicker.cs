using Newtonsoft.Json;

namespace BinanceNet.Model.General {
    // TODO: Documentation

    /// <summary>
    /// Contains best bid/ask price and quantity of symbol
    /// </summary>
    [JsonObject (MemberSerialization.OptIn)]
    public class BookTicker {
        /// <summary>
        /// Symbol of pair. e.g. LTCBTC
        /// </summary>
        [JsonProperty ("symbol")]
        public string Symbol { get; set; }
        
        [JsonProperty ("bidPrice")]
        public decimal BidPrice { get; set; }

        [JsonProperty ("bidQty")]
        public decimal BidQty { get; set; }

        [JsonProperty ("askPrice")]
        public decimal AskPrice { get; set; }

        [JsonProperty ("askQty")]
        public decimal AskQty { get; set; }
    }
}
