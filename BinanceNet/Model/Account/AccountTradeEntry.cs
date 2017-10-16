using System;
using BinanceNet.Utils;
using Newtonsoft.Json;

namespace BinanceNet.Model.Account
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountTradeEntry {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("qty")]
        public decimal Quantity { get; set; }

        [JsonProperty("commission")]
        public decimal Commission { get; set; }

        [JsonProperty("commissionAsset")]
        public string CommissionAsset { get; set; }

        [JsonProperty("time")]
        public TimeStamp Time { get; set; }
        
        [JsonProperty("isBuyer")]
        public bool IsBuyer { get; set; }

        [JsonProperty("isMaker")] 
        public bool IsMaker { get; set; }

        [JsonProperty("isBestMatch")]
        public bool IsBestMatch { get; set; }
    }
}
/* {
		    "id": 28457,
		    "price": "4.00000100",
		    "qty": "12.00000000",
		    "commission": "10.10000000",
		    "commissionAsset": "BNB",
		    "time": 1499865549590,
		    "isBuyer": true,
		    "isMaker": false,
		    "isBestMatch": true
		  }
*/