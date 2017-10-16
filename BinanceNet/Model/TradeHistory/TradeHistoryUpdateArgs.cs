using System;
using BinanceNet.Utils;
using Newtonsoft.Json;

namespace BinanceNet.Model.TradeHistory {
    /// <summary>
    /// Contains data that was getted from websocket 
    /// </summary>
    [JsonObject (MemberSerialization.OptIn)]
    public class TradeHistoryUpdateArgs {
        /// <summary>
        /// Event type (Normally need to be equal "aggTrade")
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
        /// Aggregated TradeId
        /// </summary>
        [JsonProperty (PropertyName = "a")]
        public long UpdateId { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty (PropertyName = "p")]
        public decimal Price { get; set; }

        /// <summary>
        /// Quantity that was traded
        /// </summary>
        [JsonProperty (PropertyName = "q")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// First breakdown trade id that aggregated here
        /// </summary>
        [JsonProperty (PropertyName = "f")]
        public long FirstBreakDownTradeId { get; set; }

        /// <summary>
        /// Last breakdown trade id that aggregated here
        /// </summary>
        [JsonProperty (PropertyName = "l")]
        public long LastBreakDownTradeId { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty (PropertyName = "T")]
        public TimeStamp TradeTime { get; set; }

        /// <summary>
        /// If m = false, the trade was filled on a buy side order.
        /// (Maker is buyer).
        /// If m = true, the trade was filled on a sell side order.
        /// (Maker is seller).
        /// </summary>
        [JsonProperty (PropertyName = "m")]
        public bool IsBuyerMaker { get; set; }

        /// <summary>
        /// Can be ignore
        /// </summary>
        [JsonProperty (PropertyName = "M")]
        public bool M { get; set; }
    }
}

/*
* JSON Presentation of answer from site - 
 {
	"e": "aggTrade",		// event type
	"E": 1499405254326,		// event time
	"s": "ETHBTC",			// symbol
	"a": 70232,				// aggregated tradeid
	"p": "0.10281118",		// price
	"q": "8.15632997",		// quantity
	"f": 77489,				// first breakdown trade id
	"l": 77489,				// last breakdown trade id
	"T": 1499405254324,		// trade time
	"m": false,				// whehter buyer is a maker
	"M": true				// can be ignore
}
*/
