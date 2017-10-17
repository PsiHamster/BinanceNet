using System;
using BinanceNet.Enums;
using BinanceNet.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BinanceNet.Model.Account {
    // TODO: Documentation

    [JsonObject (MemberSerialization.OptIn)]
    public class NewOrderRequest {

        [JsonProperty ("symbol"), JsonRequired]
        public string Symbol { get; set; }

        [JsonProperty ("side"), JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderSide OrderSide { get; set; }

        [JsonProperty("type"), JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderType Type { get; set; } = OrderType.LIMIT;

        [JsonProperty("timeInForce"), JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        [JsonProperty ("quantity"), JsonRequired]
        public decimal Quantity { get; set; }

        [JsonProperty ("price"), JsonRequired]
        public decimal Price { get; set; }

        /// <summary>
        /// A unique id for the order. Automatically generated if not sent.
        /// Not mandatory
        /// </summary>
        [JsonProperty ("newClientOrderId")]
        public string NewClientOrderId { get; set; }

        /// <summary>
        /// Used with stop orders
        /// Not mandatory
        /// </summary>
        [JsonProperty ("stopPrice")]
        public decimal? StopPrice { get; set; }

        /// <summary>
        /// Used with iceberg orders
        /// Not mandatory
        /// </summary>
        [JsonProperty ("icebergOnly")]
        public decimal? IcebergOnly { get; set; }

        /// <summary>
        /// Timestamp. Automaticly sets if <see cref="TimeStamp.SetTimeStampCorrection"/> was called
        /// </summary>
        [JsonProperty("timestamp"), JsonRequired]
        public TimeStamp Timestamp { get; set; } = TimeStamp.CurrentTimeStamp();
    }
}