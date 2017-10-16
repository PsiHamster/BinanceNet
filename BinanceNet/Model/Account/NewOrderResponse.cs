using System;
using Newtonsoft.Json;

namespace BinanceNet.Model.Account {
    // TODO: Documentation

    [JsonObject (MemberSerialization.OptIn)]
    public struct NewOrderResponse {
        [JsonProperty ("symbol")]
        public string Symbol { get; set; }
        [JsonProperty ("orderId")]
        public long OrderId { get; set; }
        /// <summary>
        /// A unique id for the order. Automatically generated if you don't sent it in request
        /// </summary>
        [JsonProperty ("clientOrderId")]
        public string ClientOrderId { get; set; }
        [JsonProperty ("transactTime")]
        public DateTimeOffset TransactTime { get; set; }
    }
}
