using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BinanceNet.Model
{
    // TODO: Documentation

    [JsonObject(MemberSerialization.OptIn)]
    public class CancelOrderResponse
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("origClientOrderId")]
        public string OrigClientOrderId { get; set; }
        /// <summary>
        /// A id of order
        /// </summary>
        [JsonProperty("orderId")]
        public long OrderId { get; set; }
        [JsonProperty("clientOrderId")]
        public string ClientOrderId { get; set; }
    }
}
