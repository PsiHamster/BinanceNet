using System;
using BinanceNet.Enums;
using BinanceNet.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BinanceNet.Model.Account
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ExecutionReportUpdateArgs
    {
        /// <summary>
        /// Event type (Normally need to be equal "outboundAccountInfo")
        /// </summary>
        [JsonProperty("e")]
        public string EventType { get; set; }
        /// <summary>
        /// Time of event
        /// </summary>
        [JsonProperty("E")]
        public TimeStamp EventTime { get; set; }
        /// <summary>
        /// String contains name of trading pair e.g. BNBBTC
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; }
        /// <summary>
        /// newClientOrderId
        /// </summary>
        [JsonProperty("c")]
        public string ClientOrderId { get; set; }
        /// <summary>
        /// side: buy or sell
        /// </summary>
        [JsonProperty("S")]
        public string Side { get; set; }
        /// <summary>
        /// order type
        /// </summary>
        [JsonProperty("o")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderType OrderType { get; set; }
        /// <summary>
        /// time in force, GTC: Good Till Cancel, IOC: Immediate or Cancel
        /// </summary>
        [JsonProperty("f")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeInForce TimeInForce { get; set; }
        /// <summary>
        /// Original quantity
        /// </summary>
        [JsonProperty("q")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("p")]
        public decimal Price { get; set; }
        [JsonProperty("P")]
        public decimal P { get; set; }
        [JsonProperty("F")]
        public decimal F { get; set; }
        [JsonProperty("g")]
        public long g { get; set; }
        [JsonProperty("C")]
        public string C { get; set; }
        [JsonProperty("x")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ExecutionType ExecutionType { get; set; }
        [JsonProperty("X")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderStatus OrderStatus { get; set; }
        [JsonProperty("r")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderRejectReason RejectReason { get; set; }
        [JsonProperty("i")]
        public long OrderId { get; set; }
        [JsonProperty("l")]
        public decimal QuantityOfLastFilledTrade { get; set; }
        [JsonProperty("z")]
        public decimal AccumulatedQuantityOfFilledTrades { get; set; }
        [JsonProperty("L")]
        public decimal PriceOfLastFilledTrade { get; set; }
        [JsonProperty("n")]
        public long Comission { get; set; }
        [JsonProperty("N")]
        public string ComissionAsset { get; set; }
        [JsonProperty("T")]
        public TimeStamp TradeTime { get; set; }
        [JsonProperty("t")]
        public long TradeId { get; set; }
        [JsonProperty("I")]
        public long I { get; set; }
        [JsonProperty("w")]
        public bool w { get; set; }
        [JsonProperty("m")]
        public bool IsBuyerMaker { get; set; }
        [JsonProperty("M")]
        public bool M { get; set; }
    }
}
