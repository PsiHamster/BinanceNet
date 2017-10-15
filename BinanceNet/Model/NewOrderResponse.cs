using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model {
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
