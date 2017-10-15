using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BinanceNet.Enums;

namespace BinanceNet.Model {
    // TODO: Documentation

    [JsonObject (MemberSerialization.OptIn)]
    public struct NewOrderRequest {
        [JsonProperty ("symbol")]
        public string Symbol { get; set; }
        [JsonProperty ("side")]
        public OrderSide Side { get; set; }
        [JsonProperty ("type")]
        public OrderType Type { get; set; }
        [JsonProperty ("timeInForce")]
        public TimeInForce timeInForce { get; set; }
        [JsonProperty ("quantity")]
        public decimal Quantity { get; set; }
        [JsonProperty ("price")]
        public decimal Price { get; set; }
        [JsonProperty ("newClientOrderId")]
        public string NewClientOrderId { get; set; }
        [JsonProperty ("stopPrice")]
        public decimal? StopPrice { get; set; }
        [JsonProperty ("icebergOnly")]
        public decimal? IcebergOnly { get; set; }
        [JsonProperty ("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
    }
}
