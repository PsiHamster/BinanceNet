using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BinanceNet.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountInformation {

        [JsonProperty("makerCommission")]
        public long MakerCommission { get; set; }

        [JsonProperty("takerCommission")]
        public long TakerCommission { get; set; }

        [JsonProperty("buyerCommission")]
        public long BuyerCommission { get; set; }

        [JsonProperty("sellerCommission")]
        public long SellerCommission { get; set; }

        /// <summary>
        /// Can account place orders.
        /// </summary>
        [JsonProperty("canTrade")]
        public bool CanTrade { get; set; }

        /// <summary>
        /// Can account withdraw assets.
        /// </summary>
        [JsonProperty("canWithdraw")]
        public bool CanWithdraw { get; set; }

        /// <summary>
        /// Can account deposit assets.
        /// </summary>
        [JsonProperty("canDeposit")]
        public bool CanDeposit { get; set; }

        /// <summary>
        /// Array of balances.
        /// </summary>
        [JsonProperty("balances")]
        public AccountAssetBalance[] Balances { get; set; }

    }
}
