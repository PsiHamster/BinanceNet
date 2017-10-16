using BinanceNet.Model.CandleSticks;
using BinanceNet.Utils;
using Newtonsoft.Json;

namespace BinanceNet.Model.DepthBook {
    /// <summary>
    /// One order in depth book
    /// </summary>
    [JsonConverter (typeof (ObjectToArrayConverter<CandleStick>))]
    public class DepthBookOrderEntry {
        /// <summary>
        /// Order price
        /// </summary>
        [JsonProperty (Order = 1)]
        public decimal Price { get; }
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty (Order = 2)]
        public decimal Quantity { get; }
    }
}
