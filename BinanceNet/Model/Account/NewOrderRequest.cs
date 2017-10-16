﻿using System;
using BinanceNet.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BinanceNet.Model.Account {
    // TODO: Documentation

    [JsonObject (MemberSerialization.OptIn)]
    public struct NewOrderRequest {
        [JsonProperty ("symbol"), JsonRequired]
        public string Symbol { get; set; }
        [JsonProperty ("side"), JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderSide OrderSide { get; set; }
        [JsonProperty ("type"), JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderType Type { get; set; }
        [JsonProperty ("timeInForce"), JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeInForce TimeInForce { get; set; }
        [JsonProperty ("quantity"), JsonRequired]
        public decimal Quantity { get; set; }
        [JsonProperty ("price"), JsonRequired]
        public decimal Price { get; set; }
        [JsonProperty ("newClientOrderId")]
        public string NewClientOrderId { get; set; }
        [JsonProperty ("stopPrice")]
        public decimal? StopPrice { get; set; }
        [JsonProperty ("icebergOnly")]
        public decimal? IcebergOnly { get; set; }
        [JsonProperty ("timestamp"), JsonRequired]
        public DateTimeOffset Timestamp { get; set; }
    }
}