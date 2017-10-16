using Newtonsoft.Json;

namespace BinanceNet.Model.Account
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
