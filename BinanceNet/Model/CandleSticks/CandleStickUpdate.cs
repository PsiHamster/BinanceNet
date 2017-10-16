using System;
using BinanceNet.Enums;
using BinanceNet.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BinanceNet.Model.CandleSticks
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CandleStickUpdate
    {
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty("t")]
        public TimeStamp OpenTime { get; set; }

        /// <summary>
        /// When stick is close
        /// </summary>
        [JsonProperty("T")]
        public TimeStamp CloseTime { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        [JsonProperty("s")]
        public decimal Symbol { get; set; }

        /// <summary>
        /// Interval of sticks
        /// </summary>
        [JsonProperty("i")]
        [JsonConverter(typeof(StringEnumConverter))]
        public KlineInterval Interval { get; set; }

        /// <summary>
        /// First trade ID
        /// </summary>
        [JsonProperty("f")]
        public long FirstTradeId { get; set; }

        /// <summary>
        /// Last trade ID
        /// </summary>
        [JsonProperty("L")]
        public long LastTradeId { get; set; }

        /// <summary>
        /// Price on start of the period
        /// </summary>
        [JsonProperty("o")]
        public decimal OpenPrice { get; set; }

        /// <summary>
        /// Price on end of the period
        /// </summary>
        [JsonProperty("c")]
        public decimal ClosePrice { get; set; }

        /// <summary>
        /// Max price that was touched
        /// </summary>
        [JsonProperty("h")]
        public decimal MaxPrice { get; set; }

        /// <summary>
        /// Lowest price that was touched
        /// </summary>
        [JsonProperty("l")]
        public decimal MinPrice { get; set; }
        
        /// <summary>
        /// Volume of trades
        /// </summary>
        [JsonProperty("v")]
        public decimal Volume { get; set; }
        
        /// <summary>
        /// Number of trades in the period
        /// </summary>
        [JsonProperty("n")]
        public long NumberOfTrades { get; set; }

        /// <summary>
        /// Is this final update of bar.
        /// </summary>
        [JsonProperty("x")]
        public bool IsBarClosed { get; set; }

        /// <summary>
        /// Quote volume
        /// </summary>
        [JsonProperty("q")]
        public decimal QuoteVolume { get; set; }

        /// <summary>
        /// Volume of active buy
        /// </summary>
        [JsonProperty("V")]
        public decimal ActiveBuyVolume { get; set; }

        /// <summary>
        /// Quote volume of active buy
        /// </summary>
        [JsonProperty("Q")]
        public decimal QuoteVolumeActiveBuy { get; set; }

        /// <summary>
        /// Unknown param.
        /// </summary>
        [JsonProperty("B")]
        public decimal CanBeIgnored { get; set; }
    }
}