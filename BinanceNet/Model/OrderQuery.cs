using BinanceNet.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;

namespace BinanceNet.Model {
    // TODO : Documentation

    [JsonObject(MemberSerialization.OptIn)]
    public class OrderQuery {
        [JsonProperty ("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("orderId")]
        public long OrderId { get; set; }

        [JsonProperty ("newClientOrderId")]
        public string NewClientOrderId { get; set; }

        [JsonProperty ("price")]
        public decimal Price { get; set; }

        [JsonProperty ("origQty")]
        public decimal OrigQuantity { get; set; }

        [JsonProperty ("executedQty")]
        public decimal ExecutedQuantity { get; set; }

        [JsonProperty ("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderStatus OrderStatus { get; set; }

        [JsonProperty ("timeInForce")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeInForce TimeInForce { get; set; }
        
        [JsonProperty ("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderType OrderType { get; set; }

        [JsonProperty ("side")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderSide OrderSide { get; set; }

        [JsonProperty ("stopPrice")]
        public decimal StopPrice { get; set; }

        [JsonProperty ("icebergQty")]
        public decimal IcebergQuantity { get; set; }

        [JsonProperty ("time")]
        public DateTimeOffset Timestamp { get; set; }
    }
}

/*{
		  "symbol": "LTCBTC",
		  "orderId": 1,
		  "clientOrderId": "myOrder1",
		  "price": "0.1",
		  "origQty": "1.0",
		  "executedQty": "0.0",
		  "status": "NEW",
		  "timeInForce": "GTC",
		  "type": "LIMIT",
		  "side": "BUY",
		  "stopPrice": "0.0",
		  "icebergQty": "0.0",
		  "time": 1499827319559
		}*/
        