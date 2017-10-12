using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model.EventArgs {
    [JsonObject (MemberSerialization.OptIn)]
    public class TradeUpdateArgs {
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


        [JsonProperty (PropertyName = "p")]
        public decimal Price { get; set; }

        [JsonProperty (PropertyName = "q")]
        public decimal Quantity { get; set; }

        [JsonProperty (PropertyName = "f")]
        public long FirstBreakDownTradeId { get; set; }

        [JsonProperty (PropertyName = "l")]
        public long LastBreakDownTradeId { get; set; }


        [JsonProperty (PropertyName = "T")]
        public long TradeTime { get; set; }

        [JsonProperty (PropertyName = "m")]
        public bool IsBuyerMaker { get; set; }

        [JsonProperty (PropertyName = "M")]
        public bool M { get; set; }
    }
}
/*
 * {
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
