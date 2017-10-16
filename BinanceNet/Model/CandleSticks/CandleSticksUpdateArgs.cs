using System;
using Newtonsoft.Json;

namespace BinanceNet.Model.CandleSticks {
    [JsonObject (MemberSerialization.OptIn)]
    public class CandleSticksUpdateArgs {
        /// <summary>
        /// Event type (Normally need to be equal "kline")
        /// </summary>
        [JsonProperty(PropertyName = "e")]
        public string EventType { get; set; }

        /// <summary>
        /// Time of event 
        /// </summary>
        [JsonProperty(PropertyName = "E")]
        public DateTimeOffset EventTime { get; set; }

        /// <summary>
        /// String contains name of trading pair e.g. BNBBTC
        /// </summary>
        [JsonProperty(PropertyName = "s")]
        public string Symbol { get; set; }

        /// <summary>
        /// Contains new bar
        /// </summary>
        [JsonProperty(PropertyName = "k")]
        public CandleStickUpdate CandleStickUpd { get; set; }
    }
}
