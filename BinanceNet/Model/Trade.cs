using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model {
    [JsonObject (MemberSerialization.OptIn)]
    public class AggregatedTrade {
        [JsonProperty ("q")]
        public decimal Quantity { get; }
        [JsonProperty ("p")]
        public decimal Price { get; }
        [JsonProperty ("a")]
        public long AggregateTradeId { get; }
        [JsonProperty ("f")]
        public long FirstTradeId { get; }
        [JsonProperty ("l")]
        public long LastTradeId { get; }
        [JsonProperty ("T")]
        public DateTimeOffset TimeStamp { get; }
        [JsonProperty ("m")]
        public bool IsBuyerMaker { get; }
        [JsonProperty ("M")]
        public bool WasTheTradeBestPrice { get; }
    }
}
