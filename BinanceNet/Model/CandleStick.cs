using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Utils;
using Newtonsoft.Json;

namespace BinanceNet.Model {
    /// <summary>
    /// Contains one kline bar uniquely identified by open time.
    /// </summary>
    [JsonConverter (typeof (ObjectToArrayConverter<CandleStick>))]
    public class CandleStick {
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty (Order = 1)]
        public DateTimeOffset OpenTime { get; set; }

        /// <summary>
        /// When stick is open
        /// </summary>
        [JsonProperty (Order = 2)]
        public decimal OpenPrice { get; set; }

        /// <summary>
        /// Max price that was touched
        /// </summary>
        [JsonProperty (Order = 3)]
        public decimal MaxPrice { get; set; }

        /// <summary>
        /// Lowest price that was touched
        /// </summary>
        [JsonProperty (Order = 4)]
        public decimal MinPrice { get; set; }

        /// <summary>
        /// Price when timeperiod was closed.
        /// </summary>
        [JsonProperty (Order = 5)]
        public decimal ClosePrice { get; set; }

        /// <summary>
        /// Volume of trades
        /// </summary>
        [JsonProperty (Order = 6)]
        public decimal Volume { get; set; }

        /// <summary>
        /// When stick is close
        /// </summary>
        [JsonProperty (Order = 7)]
        public DateTimeOffset CloseTime { get; set; }

        [JsonProperty (Order = 8)]
        public decimal QuoteAssetVolume { get; set; }

        /// <summary>
        /// How many trades was closed in this timeperiod
        /// </summary>
        [JsonProperty (Order = 9)]
        public long NumberOfTrades { get; set; }

        /// <summary>
        /// Taker buy base asset volume
        /// </summary>
        [JsonProperty (Order = 10)]
        public decimal TakerBaseAssetVolume { get; set; }

        /// <summary>
        /// Taker buy quote asset volume
        /// </summary>
        [JsonProperty (Order = 11)]
        public decimal TakerQuoteAssetVolume { get; set; }

        /// <summary>
        /// Unknown param.
        /// </summary>
        [JsonProperty (Order = 12)]
        public decimal CanBeIgnored { get; set; }

        public CandleStick() { }
    }
}
